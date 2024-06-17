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

            List<Models.File> mediaList = new List<Models.File>();

            if (Directory.Exists(filesPath))
            {
                string[] files = Directory.GetFiles(filesPath);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string fileType = Path.GetExtension(file);

                    mediaList.Add(new Models.File { FileName = fileName, FileType = fileType });
                }
            }

            return View(mediaList);
        }

    }
}
