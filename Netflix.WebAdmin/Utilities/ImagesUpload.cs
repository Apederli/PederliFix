using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace Netflix.WebAdmin.Utilities
{
    public class ImagesUpload
    {
        public string UploadImages(string webRootPath, string imageClassPath, IFormFile formfile)
        {
            string fileName = null;
            if (formfile != null)
            {
                string uploadDir = Path.Combine(webRootPath, imageClassPath);

                fileName = DateTime.Now.ToString("MM-dd-yyyy-HH-mm-ss") + "-" + formfile.FileName;

                string filePath = Path.Combine(uploadDir, fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    formfile.CopyTo(fileStream);

                }
            }


            return fileName;
        }

    }
}
