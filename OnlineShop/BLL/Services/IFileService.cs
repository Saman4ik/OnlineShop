
namespace OnlineShop.BLL.Services;
public class IFileService(IWebHostEnvironment webHostEnvironment)
    : Interfaces.IFileService
{
    private readonly IWebHostEnvironment _webHostEnvironment = webHostEnvironment;

    public void DeledeImage(string filename)
    {
        var wwwrootFolder = _webHostEnvironment.WebRootPath;
        var filePath = Path.Combine(wwwrootFolder, filename.Replace("~/", ""));
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }
    }

    public string UploadImage(IFormFile file)
    {
        var wwwrotFolder = _webHostEnvironment.WebRootPath;
        var uniqeFileName = Guid.NewGuid().ToString() + "_" + file.Name;
        var filePath = Path.Combine(wwwrotFolder + "/images/", uniqeFileName);
        using (var fileStream = new FileStream(filePath, FileMode.Create))
        {
            file.CopyTo(fileStream);
        }
        return $"~/images/{uniqeFileName}";
    }
}