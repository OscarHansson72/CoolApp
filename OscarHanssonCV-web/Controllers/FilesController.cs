using CoolWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.IO;


namespace CoolWebsite.Controllers
{
    public class FilesController : Controller
    {

        public IActionResult ListFiles()
        {
            string filesPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files");

            List<Models.FileModel> mediaList = new List<Models.FileModel>();

            if (Directory.Exists(filesPath))
            {
                string[] files = Directory.GetFiles(filesPath);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string fileType = Path.GetExtension(file);

                    mediaList.Add(new Models.FileModel { FileName = fileName, FileType = fileType });
                }
            }

            return View(mediaList);
        }

    }
}
