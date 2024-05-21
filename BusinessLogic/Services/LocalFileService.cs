using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace BusinessLogic.Services
{
    public class LocalFileService : IFileService
    {
        private const string imageFolder = "images";
        private readonly IWebHostEnvironment environment;

        public LocalFileService(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        public Task DeleteMovieImage(string path)
        {
            throw new NotImplementedException();
        }

        public async Task<string> SaveMovieImage(IFormFile file)
        {
            // get image destination path
            string root = environment.WebRootPath;      // wwwroot
            string name = Guid.NewGuid().ToString();    // random name
            string extension = Path.GetExtension(file.FileName); // get original extension
            string fullName = name + extension;         // full name: name.ext

            // create destination image file path
            string imagePath = Path.Combine(imageFolder, fullName);
            string imageFullPath = Path.Combine(root, imagePath);

            // save image on the folder
            using (FileStream fs = new FileStream(imageFullPath, FileMode.Create))
            {
                await file.CopyToAsync(fs);
            }

            // return image file path
            return Path.DirectorySeparatorChar + imagePath;
        }
    }
}
