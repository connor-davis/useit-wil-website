using Microsoft.AspNetCore.Mvc;

namespace useitwebsite.Controllers
{
    public class FileController : Controller
    {
        // Action to serve the APK file
        public IActionResult DownloadApp()
        {
            // Define the path to the file
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "resources", "UseIt-Blogs-Release.apk");

            // Check if the file exists
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound(); // Return a 404 if the file is not found
            }

            // Return the file for download
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "application/vnd.android.package-archive", "UseIt-Blogs-Release.apk");
        }
    }
}
