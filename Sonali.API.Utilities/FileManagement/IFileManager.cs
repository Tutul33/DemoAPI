using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Utilities.FileManagement
{
    public interface IFileManager
    {
        Task<List<string>> UploadFilesAsync(List<IFormFile> files, string relativeFolderPath);
        Task<string> ReplaceFileAsync(string oldRelativePath, IFormFile newFile, string relativeFolderPath);
        void DeleteFile(string relativePath);
        void DeleteFolder(string relativePath);
        string BasePath { get; }
    }
}
