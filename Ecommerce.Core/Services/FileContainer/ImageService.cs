namespace Ecommerce.Application.Services.FileContainer;

public sealed class ImageService : IFileService
{
    private readonly IFileValidation _fileValidation;
    private readonly IWebHostEnvironment _webHostEnvironment;

    public ImageService(IFileValidation fileValidation, IWebHostEnvironment webHostEnvironment)
    {
        _fileValidation = fileValidation;
        _webHostEnvironment = webHostEnvironment;
    }

    public void DeleteFileAsync(string fileName)
    {
        string path = Path.Combine(_webHostEnvironment.WebRootPath, fileName);
        if (!File.Exists(path))
            return;
        if (File.Exists(path))
        {
            File.Delete(path);
        }
    }

    public string SaveFileAsync(IFormFile file)
    {
        string nameFile = $"{Guid.NewGuid()}{file.FileName}";
        string path = Path.Combine(_webHostEnvironment.WebRootPath, "Images", nameFile);
        if (!Directory.Exists(_webHostEnvironment.WebRootPath + "/Images"))
        {
            Directory.CreateDirectory(_webHostEnvironment.WebRootPath + "/Images");
        }
        using FileStream fileStream = new FileStream(path, FileMode.Create);
        file.CopyTo(fileStream);
        return "Images/" + nameFile;
    }
}
