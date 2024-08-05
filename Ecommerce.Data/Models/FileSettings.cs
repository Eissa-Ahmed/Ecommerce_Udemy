namespace Ecommerce.Domain.Models;

public sealed class FileSettings
{
    public FileType Images { get; set; } = null!;
    public FileType Audios { get; set; } = null!;
    public FileType Videos { get; set; } = null!;
}

public sealed class FileType
{
    public List<string> AllowedExtensions { get; set; } = new List<string>();
    public long MaxSize { get; set; }
}
