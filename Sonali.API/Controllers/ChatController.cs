using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.Entities;
using Sonali.API.Domain.Interface;
using Sonali.API.DomainService.Interface;
using Sonali.API.Hubs;
using Sonali.API.Utilities;
using Sonali.API.Utilities.FileManagement;

namespace Sonali.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IHubContext<ChatHub> _hub;
        private readonly FileUploadSettings _settings;
        private readonly IChatRepository _repo;
        private readonly IChatDomainService _repoDomain;
        public ChatController(IHubContext<ChatHub> hub, IOptions<FileUploadSettings> settings, IChatRepository repo, IChatDomainService repoDomain)
        {
            _hub = hub;
            _settings = settings.Value;
            _repo = repo;
            _repoDomain = repoDomain;
        }

        [HttpPost("send/{receiver}")]
        public async Task<IActionResult> Send(string receiver, [FromForm] List<IFormFile> files, [FromQuery] string sender, [FromForm] string? message)
        {
            List<ChatFileDto> chatFiles = new List<ChatFileDto>();
            foreach (var item in files)
            {
                var fileMessage = new ChatFileDto
                {
                    FileName = item.FileName,
                    FileType = item.ContentType,
                    FileUrl = "",
                    SentDate = DateTime.UtcNow,
                    Tag = EntityState.Added,
                    File= item
                };
                chatFiles.Add(fileMessage);
            }
            

            var chatMessage = new ChatMessageFileDto
            {
                Sender = sender,
                Receiver = receiver,
                Text = message,  
                Files = chatFiles,
                SentDate = DateTime.UtcNow
            };
            var messageDto =await _repo.SaveMessageAsync(chatMessage, files);
            
            // Notify receiver via SignalR
            var connId = ChatHub.GetConnectionId(receiver);
            if (!string.IsNullOrEmpty(connId))
            {
                await _hub.Clients.Client(connId).SendAsync("ReceiveFile", sender, messageDto);
            }

            return Ok(messageDto); // return URL to sender
        }

        [HttpGet("download/{fileType}/{fileName}")]
        public IActionResult Download(string fileType, string fileName)
        {
            try
            {
                // Full path
                //var filePath = Path.Combine(_env.ContentRootPath, "Reports", fileType, fileName);
                var filePath = Path.Combine(_settings.BasePath+"\\chatfiles", fileName);

                if (!System.IO.File.Exists(filePath))
                    return NotFound("File not found");

                // Get bytes
                var fileBytes = System.IO.File.ReadAllBytes(filePath);

                // Determine content type
                string contentType = fileName.EndsWith(".pdf") ? "application/pdf" :
                                     fileName.EndsWith(".docx") ? "application/vnd.openxmlformats-officedocument.wordprocessingml.document" :
                                     fileName.EndsWith(".xlsx") ? "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" :
                                     "application/octet-stream";

                return File(fileBytes, contentType, fileName);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet("messages/{user1}/{user2}")]
        public async Task<IActionResult> GetMessages(string user1, string user2, int page = 1, int pageSize = 20)
        {
            var messages = await _repoDomain.GetMessagesAsync(user1, user2, page, pageSize);
            return Ok(messages); 
        }

        [HttpDelete("delete-message/{sender}/{receiver}/{id}")]
        public async Task<IActionResult> DeleteMessage(string sender,string receiver, int id)
        {
            try
            {
                await _repo.DeleteMessageAsync(id);

                var sendConnId = ChatHub.GetConnectionId(sender);
                if (!string.IsNullOrEmpty(sendConnId))
                {
                    await _hub.Clients.Client(sendConnId).SendAsync("MessageDeleted",sender, id);
                }

                var recevConnId = ChatHub.GetConnectionId(receiver);
                if (!string.IsNullOrEmpty(recevConnId))
                {
                    await _hub.Clients.Client(recevConnId).SendAsync("MessageDeleted", sender, id);
                }

                return Ok(new { success = true, message = "Message deleted successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new { success = false, message = ex.Message });
            }
        }

        [HttpDelete("delete-file/{sender}/{receiver}/{fileId}")]
        public async Task<IActionResult> DeleteFile(string sender,string receiver, int fileId)
        {
            try
            {                
                await _repo.DeleteFileAsync(fileId);
               
                var senderConnId = ChatHub.GetConnectionId(sender);
                if (!string.IsNullOrEmpty(senderConnId))
                {
                    await _hub.Clients.Client(senderConnId).SendAsync("FileDeleted",sender, fileId);
                }

                var receiverConnId = ChatHub.GetConnectionId(receiver);
                if (!string.IsNullOrEmpty(receiverConnId))
                {
                    await _hub.Clients.Client(receiverConnId).SendAsync("FileDeleted", sender, fileId);
                }

                return Ok(new { success = true, message = "File deleted successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new { success = false, message = ex.Message });
            }
        }

        [HttpPut]
        [Route("update-message")]
        public async Task<IActionResult> UpdateMessage([FromBody] ChatMessageDto msgDto)
        {
            try
            {
                if (msgDto == null || msgDto.Id <= 0)
                    return BadRequest(new { success = false, message = "Invalid message data." });

                var updatedMsg = await _repo.UpdateMessageAsync(msgDto);

                // Notify sender
                var senderConnId = ChatHub.GetConnectionId(msgDto.Sender);
                if (!string.IsNullOrEmpty(senderConnId))
                {
                    await _hub.Clients.Client(senderConnId)
                        .SendAsync("MessageUpdated", msgDto.Sender, updatedMsg);
                }

                // Notify receiver
                var receiverConnId = ChatHub.GetConnectionId(msgDto.Receiver);
                if (!string.IsNullOrEmpty(receiverConnId))
                {
                    await _hub.Clients.Client(receiverConnId)
                        .SendAsync("MessageUpdated", msgDto.Sender, updatedMsg);
                }

                return Ok(new { success = true, message = "Message updated successfully.", data = updatedMsg });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new { success = false, message = ex.Message });
            }
        }



    }
}
