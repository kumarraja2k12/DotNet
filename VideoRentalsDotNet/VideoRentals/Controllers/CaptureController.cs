using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VideoRentals.Controllers
{
    public class CaptureController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CaptureController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ContentResult SaveCapture(string data)
        {
            var files = HttpContext.Request.Form.Files;
            if (files != null)
            {
                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        // Getting Filename  
                        var fileName = file.FileName;
                        // Unique filename "Guid"  
                        var myUniqueFileName = Convert.ToString(Guid.NewGuid());
                        // Getting Extension  
                        var fileExtension = Path.GetExtension(fileName);
                        // Concating filename + fileExtension (unique filename)  
                        var newFileName = string.Concat(myUniqueFileName, fileExtension);
                        //  Generating Path to store photo   
                        var filepath = Path.Combine(_webHostEnvironment.WebRootPath, "CameraPhotos") + $@"\{newFileName}";

                        if (!string.IsNullOrEmpty(filepath))
                        {
                            // Storing Image in Folder  
                            StoreInFolder(file, filepath);
                        }

                        /*var imageBytes = System.IO.File.ReadAllBytes(filepath);
                        if (imageBytes != null)
                        {
                            // Storing Image in Folder  
                            StoreInDatabase(imageBytes);
                        }*/

                    }
                }
                return Content("true");
            }
            else
            {
                return Content("false");
            }
        }

        private void StoreInFolder(IFormFile file, string fileName)
        {
            using (FileStream fs = System.IO.File.Create(fileName))
            {
                file.CopyTo(fs);
                fs.Flush();
            }
        }
    }
}
