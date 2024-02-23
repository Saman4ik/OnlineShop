namespace OnlineShop.BLL.Interfaces;
public interface IFileService
{
    string UploadImage(IFormFile file);
    void DeledeImage(string filename);
}