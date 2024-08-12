namespace Ecommerce.Application.Services.IServices.IFileContainer;

public interface IFileService
{
    public string SaveFileAsync(IFormFile file);
    public void DeleteFileAsync(string fileName);
}
