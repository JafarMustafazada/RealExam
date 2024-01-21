
namespace WebApplicationExam.Extensions;

public static class FileExtensions
{
    public static string Root { get; set; }

    public static bool IsContentType(this IFormFile file, string contentType = "image")
        => file.ContentType.Contains(contentType);

    public static async Task<string> SaveFileAsync(this IFormFile file, string customPath = "data")
    {
        string name = file.FileName;
        name = Path.GetFileNameWithoutExtension(name).Length > 32 ? name.Substring(0, 32) + Path.GetExtension(name) : name;
        name = Path.GetRandomFileName() + name;

        string path = Path.Combine(customPath, name);

        using (FileStream fs = File.Create(Path.Combine(FileExtensions.Root, path))) 
        {
            await file.CopyToAsync(fs);
        }

        return path;
    }
}
