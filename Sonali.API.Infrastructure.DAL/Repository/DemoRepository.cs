using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Sonali.API.Domain.DTOs.DemoDTO;
using Sonali.API.Domain.Entities.Demo;
using Sonali.API.Domain.Interface;
using Sonali.API.Infrastructure.Data.Data;
using Sonali.API.Infrastructure.Data.Models;
using Sonali.API.Utilities.FileManagement;

namespace Sonali.API.Infrastructure.DAL.Repository
{
    public class DemoRepository : IDemoRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IFileManager _fileManager;
        public DemoRepository(AppDbContext dbContext, IMapper mapper, IFileManager fileManager)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext), "Database context cannot be null");
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper), "Mapper cannot be null");
            _fileManager = fileManager ?? throw new ArgumentNullException(nameof(fileManager));
        }
        public async Task<DemoDTO> Save(DemoDTO demo, List<IFormFile> files)
        {
            try
            {
                if (demo == null)
                    throw new ArgumentNullException(nameof(demo), "Demo cannot be null");

                var demoEntity = demo as Demos;// Please explain that
                var demoObj = _mapper.Map<AccDemo>(demoEntity);
                if (demoObj.Id > 0)
                {
                    _dbContext.AccDemos.Update(demoObj);
                }
                else
                {
                    demoObj.IsActive = true;
                    demoObj.CreateDate = DateTime.Now;
                    _dbContext.AccDemos.Add(demoObj);
                }

                await _dbContext.SaveChangesAsync();
                demo.Id = demoObj.Id;
                demo.DemoItems=await ManageDemoItem(demoObj.Id, demo.DemoItems, files);

                return demo;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private async Task<List<DemoItems>> ManageDemoItem(int demoId, List<DemoItems> demoItems, List<IFormFile> files)
        {
            try
            {
                foreach (var item in demoItems)
                {
                    switch (item.Tag)
                    {
                        case EntityState.Added:
                            var entity = _mapper.Map<AccDemoItem>(item);
                            entity.DemoId = demoId;
                            entity.IsActive = true;
                            _dbContext.AccDemoItems.Add(entity);
                            await _dbContext.SaveChangesAsync();

                            item.Id = entity.Id;
                            item.DemoId = demoId;
                            if (entity.Id > 0)
                                await ManageDemoItemAttachment(demoId, entity.Id, item.DemoItemFileAttachments, files);
                            break;

                        case EntityState.Modified:
                            var existing = _mapper.Map<AccDemoItem>(item);
                            _dbContext.AccDemoItems.Update(existing);
                            await _dbContext.SaveChangesAsync();

                            item.DemoItemFileAttachments = await ManageDemoItemAttachment(demoId, existing.Id, item.DemoItemFileAttachments, files);
                            break;

                        case EntityState.Deleted:
                            var toDelete = await _dbContext.AccDemoItems.FindAsync(item.Id);
                            if (toDelete != null)
                            {
                                _dbContext.AccDemoItems.Remove(toDelete);
                                await _dbContext.SaveChangesAsync();

                                item.DemoItemFileAttachments = await ManageDemoItemAttachment(demoId, item.Id, item.DemoItemFileAttachments, files);
                            }
                            break;
                    }
                }
                demoItems = demoItems.Where(x => x.Tag != EntityState.Deleted).ToList();
                return demoItems;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task<List<DemoItemFileAttachments>> ManageDemoItemAttachment(int demoId, int demoItemId, List<DemoItemFileAttachments> attachments, List<IFormFile> files)
        {
            try
            {
                string folder = Path.Combine(Folders.Demo, demoItemId.ToString());

                foreach (var att in attachments)
                {
                    switch (att.Tag)
                    {
                        case EntityState.Added:
                            var file = files.FirstOrDefault(f => f.FileName == att.FileName);
                            if (file != null)
                            {
                                var uploaded = await _fileManager.UploadFilesAsync(new List<IFormFile> { file }, folder);
                                var entityIn = new AccDemoItemFileAttachment
                                {
                                    DemoItemId = demoItemId,
                                    FileName = uploaded.First(),
                                    IsActive = true
                                };
                                _dbContext.AccDemoItemFileAttachments.Add(entityIn);
                                await _dbContext.SaveChangesAsync();
                                att.Id = entityIn.Id;
                                att.DemoItemId = demoItemId;
                                att.FileName = entityIn.FileName;
                            }
                            break;

                        case EntityState.Modified:
                            var fileUpdate = files.FirstOrDefault(f => f.FileName == att.FileName);
                            if (fileUpdate != null)
                            {
                                var oldFileName = folder + "\\" + att.FileName;
                                var newPath = await _fileManager.ReplaceFileAsync(oldFileName, fileUpdate, folder);
                                att.FileName = newPath;
                                _dbContext.AccDemoItemFileAttachments.Update(_mapper.Map<AccDemoItemFileAttachment>(att));
                                await _dbContext.SaveChangesAsync();
                            }
                            break;

                        case EntityState.Deleted:
                            var entity = await _dbContext.AccDemoItemFileAttachments.FindAsync(att.Id);
                            if (entity != null)
                            {
                                var fileName = folder + "\\" + att.FileName;
                                _fileManager.DeleteFile(fileName);
                                _dbContext.AccDemoItemFileAttachments.Remove(entity);
                                await _dbContext.SaveChangesAsync();
                            }
                            break;
                    }
                }
                attachments = attachments.Where(x => x.Tag != EntityState.Deleted).ToList();
                return attachments;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var demo = await _dbContext.AccDemos.AsNoTracking().FirstOrDefaultAsync(i => i.Id == id);
                if (demo == null)
                    throw new KeyNotFoundException($"Demo with ID {id} not found.");

                _dbContext.AccDemos.Remove(demo);

                var demoItems = await _dbContext.AccDemoItems.AsNoTracking().Where(e => e.DemoId == id).ToListAsync();
                if (demoItems.Count > 0)
                {

                    foreach (var item in demoItems)
                    {
                        var demoItemAttachList = await _dbContext.AccDemoItemFileAttachments.AsNoTracking().Where(e => e.DemoItemId == item.Id).ToListAsync();
                        if (demoItemAttachList.Count > 0)
                        {
                            _dbContext.AccDemoItemFileAttachments.RemoveRange(demoItemAttachList);
                        }

                        string folder = Path.Combine(Folders.Demo, item.Id.ToString());
                        _fileManager.DeleteFolder(folder);
                    }

                    _dbContext.AccDemoItems.RemoveRange(demoItems);
                }

                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
