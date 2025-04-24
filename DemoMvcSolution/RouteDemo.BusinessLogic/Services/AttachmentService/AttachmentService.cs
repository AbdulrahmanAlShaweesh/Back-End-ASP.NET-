

using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;
using static System.Net.Mime.MediaTypeNames;

namespace RouteDemo.BusinessLogic.Services.AttachmentService
{
    public class AttachmentService : IAttachmentService
    {
        List<string> AllowedExtentions = [".png", ".jpg", ".jpeg"];
        const int MaxFileSize = 2_097_152;   // max file length we save take. we use const keyword becouse we need the file length be const no one can change it, but if we need to change it in some how then we can not make it const

        public string? Upload(IFormFile file, string FolderName)
        {
            // Upload file into server : wwwroot and then save the file into the db
            // 1. check extention , if it is from the allowed  or not
            var extention = Path.GetExtension(file.FileName);  // .png ==> get the extention
            if (!AllowedExtentions.Contains(extention)) return null;

            // 2. Check the file size
            if (file.Length == 0 || file.Length > MaxFileSize) return null;

            // 3. Get the alocated local folder path
            //var FolderPath = $"{Directory.GetCurrentDirectory()}\\wwwroot\\Files\\{FolderName}";
            var FolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Files", FolderName);  // better 

            // Make the attachment Unique -- GUID
            var fileName = $"{Guid.NewGuid()}_{file.FileName}"; // this file name will same into the db and will be a unique name

            // 4. Get File Path
            var FilePath = Path.Combine(FolderPath, fileName);  // file location

            // we create the above steps, becouse we need to create file stream on a spesific file name
            // 5. create file stream to copy file[unmanged]
            using FileStream fileStream = new FileStream(FilePath, FileMode.Create);  // after we create file, we need to close it used using

            // 7. use stream to copy to file
            file.CopyTo(fileStream);

            // 8. return filename to store in db

            return fileName;
        }

        public bool Delete(string FilePath)
        {
            // we need to have file path, and we do not have it [ it must send two info file name and folder that inside, and we need to create file path]
            // in this example we consder we have the full path. 

            // 1. Get file path
            // 2. Check if File Exists Or Not If Exists Remove It
            if (!File.Exists(FilePath)) return false;
            else
            {
                File.Delete(FilePath);
                return true;

            }

        }


    }
}
