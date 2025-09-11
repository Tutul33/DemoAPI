using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.Entities;
using Sonali.API.Domain.Entities.Demo;
using Sonali.API.Domain.Interface;
using Sonali.API.Infrastructure.Data.Data;
using Sonali.API.Infrastructure.Data.Models;
using Sonali.API.Utilities.FileManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Infrastructure.DAL.Repository
{
    public class ChatRepository : IChatRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IFileManager _fileManager;
        public ChatRepository(AppDbContext dbContext, IMapper mapper, IFileManager fileManager)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext), "Database context cannot be null");
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper), "Mapper cannot be null");
            _fileManager = fileManager ?? throw new ArgumentNullException(nameof(fileManager));
        }
        public async Task<bool> DeleteMessageAsync(int id)
        {
            try
            {
                var message = await _dbContext.ChatMessages.Include(m => m.ChatFiles).FirstOrDefaultAsync(m => m.Id == id);
                if (message != null)
                {
                    // Delete associated files
                    foreach (var file in message.ChatFiles)
                    {
                        if (!string.IsNullOrEmpty(file.FileName))
                        {
                            await DeleteFileAsync(file.Id);
                        }
                    }
                    _dbContext.ChatMessages.Remove(message);
                    _dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> DeleteFileAsync(int id)
        {
            try
            {
                string folder = "ChatFiles";
                var file = await _dbContext.ChatFiles.FirstOrDefaultAsync(m => m.Id == id);
                if (file != null)
                {
                    if (!string.IsNullOrEmpty(file.FileUrl))
                    {
                        _fileManager.DeleteFile(folder + "\\" + file.FileUrl);
                    }
                    _dbContext.ChatFiles.Remove(file);
                    _dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<ChatMessageFileDto> SaveMessageAsync(ChatMessageFileDto message, List<IFormFile> files)
        {
            try
            {
                if (message == null)
                    throw new ArgumentNullException(nameof(message), "Message cannot be null");

                var demoEntity = message as ChatMessages;// Please explain that
                var demoObj = _mapper.Map<ChatMessage>(demoEntity);
                if (demoObj.Id > 0)
                {
                    _dbContext.ChatMessages.Update(demoObj);
                }
                else
                {
                    demoObj.IsActive = true;
                    demoObj.SentDate = DateTime.Now;
                    _dbContext.ChatMessages.Add(demoObj);
                }

                await _dbContext.SaveChangesAsync();
                message.Id = demoObj.Id;
                message.Files = await ManageFiles(demoObj.Id, message.Files, files);

                return message;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task<List<ChatFileDto>> ManageFiles(int MessageId, List<ChatFileDto> chatFiles, List<IFormFile> files)
        {
            try
            {
                foreach (var item in chatFiles)
                {
                    switch (item.Tag)
                    {
                        case EntityState.Added:
                            var entity = _mapper.Map<ChatFile>(item);
                            entity.ChatMessageId = MessageId;
                            var savedFiles = await _fileManager.UploadFilesAsync(new List<IFormFile> { item.File }, "ChatFiles");
                            var savedFileName = savedFiles.First();
                            entity.FileType = item.FileName.Split(".")[1];
                            entity.FileUrl = savedFileName;
                            entity.SentDate = DateTime.Now;
                            _dbContext.ChatFiles.Add(entity);
                            
                            await _dbContext.SaveChangesAsync();
                            item.Id = entity.Id;
                            item.FileUrl = savedFileName;
                            break;

                        case EntityState.Modified:
                            var fileUpdate = files.FirstOrDefault(f => f.FileName == item.FileName);
                            if (fileUpdate != null)
                            {
                                var oldFileName = item.FileName;
                                var newPath = await _fileManager.ReplaceFileAsync(oldFileName, fileUpdate, "ChatFiles");
                                item.FileUrl = newPath;
                                _dbContext.ChatFiles.Update(_mapper.Map<ChatFile>(item));
                                await _dbContext.SaveChangesAsync();
                            }
                            break;

                        case EntityState.Deleted:
                            var toDelete = await _dbContext.ChatFiles.FindAsync(item.Id);
                            if (toDelete != null)
                            {
                                var fileName = item.FileName;
                                _fileManager.DeleteFile(fileName);
                                _dbContext.ChatFiles.Remove(toDelete);
                                await _dbContext.SaveChangesAsync();
                            }
                            break;
                    }
                }
                chatFiles = chatFiles.Where(x => x.Tag != EntityState.Deleted).ToList();

                return chatFiles;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ChatMessageDto>> GetMessagesAsync(string user1, string user2, int page, int pageSize)
        {
            var messeage= await _dbContext.ChatMessages
                .Include(m => m.ChatFiles)
                .Where(m =>
                    (m.Sender == user1 && m.Receiver == user2) ||
                    (m.Sender == user2 && m.Receiver == user1))
                .OrderByDescending(m => m.SentDate)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(m => _mapper.Map<ChatMessageDto>(m))
                .ToListAsync();
            return messeage;
        }

        public async Task<ChatMessageDto> UpdateMessageAsync(ChatMessageDto message)
        {
            try
            {
                var messageObj = await _dbContext.ChatMessages.Include(m => m.ChatFiles).FirstOrDefaultAsync(m => m.Id == message.Id);
                if (messageObj != null)
                {
                    messageObj.Text=message.Text;
                    _dbContext.SaveChanges();
                    return _mapper.Map<ChatMessageDto>(messageObj);
                }
                return message;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
