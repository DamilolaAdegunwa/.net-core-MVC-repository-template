using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace GRA.Common
{
    public class FilesSaver
    {
        private readonly IWebHostEnvironment webHostEnvironment;

        public FilesSaver(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }

        public string Upload(IFormFile file, string mainFolderName, string subFolderName = null)
        {
            string uniqueFileName = null;

            if (file != null && mainFolderName != null)
            {
                var uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Uploads", mainFolderName, subFolderName ?? "");
                Directory.CreateDirectory(uploadsFolder);
                uniqueFileName = Guid.NewGuid() + "_" + file.FileName;
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }


        public string[] Upload(IFormFileCollection files, string mainFolderName, string subFolderName = null)
        {
            if (files == null || files.Count <= 0 || mainFolderName == null) return null;

            var result = new string[files.Count];
            for (var index = 0; index < files.Count; index++)
            {
                var file = files[index];
                result[index] = Upload(file, mainFolderName, subFolderName);
            }

            return result;
        }

        public string[] Upload(List<IFormFile> files, string mainFolderName, string subFolderName = null)
        {
            if (files == null || files.Count <= 0 || mainFolderName == null) return null;

            var result = new string[files.Count];
            for (var index = 0; index < files.Count; index++)
            {
                var file = files[index];
                result[index] = Upload(file, mainFolderName, subFolderName);
            }

            return result;
        }
    }
}