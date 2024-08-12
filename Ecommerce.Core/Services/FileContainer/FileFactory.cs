namespace Ecommerce.Application.Services.FileContainer;

public sealed class FileFactory : IFileFactory
{
    private readonly IOptions<FileSettings> _fileSettings;
    private readonly IFileValidation _fileValidation;
    private readonly IWebHostEnvironment _webHostEnvironment;
    private readonly Dictionary<FileType, List<string>> _fileTypes;

    public FileFactory(IOptions<FileSettings> fileSettings, IFileValidation fileValidation, IWebHostEnvironment webHostEnvironment)
    {
        _fileSettings = fileSettings;
        _fileValidation = fileValidation;
        _webHostEnvironment = webHostEnvironment;
        _fileTypes = new Dictionary<FileType, List<string>>
        {
            { FileType.Image, _fileSettings.Value.Images.AllowedExtensions },
            { FileType.Audio, _fileSettings.Value.Audios.AllowedExtensions },
            { FileType.Video, _fileSettings.Value.Videos.AllowedExtensions }
        };
    }

    public IFileService GetFileService(IFormFile file)
    {
        switch (getFileType(file))
        {
            case FileType.Image:
                return new ImageService(_fileValidation, _webHostEnvironment);
            default:
                throw new ArgumentOutOfRangeException("File type not found");
        }
    }

    private FileType getFileType(IFormFile file)
    {
        var fileExtension = Path.GetExtension(file.FileName).ToLower();
        foreach (var fileType in _fileTypes)
        {
            if (fileType.Value.Contains(fileExtension))
            {
                return fileType.Key;
            }
        }
        throw new ArgumentOutOfRangeException("File type not found");
    }

}
