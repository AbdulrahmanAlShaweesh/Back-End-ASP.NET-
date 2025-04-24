

using Microsoft.AspNetCore.Http;

namespace RouteDemo.BusinessLogic.Services.AttachmentService
{
    public interface IAttachmentService
    {
        // Upload : Uload the file
        public string? Upload(IFormFile file, string FolderName);  // we need to install IFormFile third party library

        // Delete
        bool Delete(string FilePath); 
    }
}
