namespace Ecommerce.Application.Services.IServices.IFileContainer;

public interface IFileFactory
{
    public IFileService GetFileService(IFormFile file);
}
