using WebApplicationExam.Extensions;
using WebApplicationExam.Models;

namespace WebApplicationExam.ViewModel.AuthVMs;

public class EditProfileVM
{
    public string? Fullname { get; set; }
    public string? FromCity { get; set; }
    public string? ImagePath { get; set; }
    public IFormFile? ImageFile { get; set; }

    public EditProfileVM() { }

    public EditProfileVM(AppUser user)
    {
        this.FromCity = user.FromCity;
        this.ImagePath = user.ImagePath;
        this.Fullname = user.FullName;
    }

    public async Task UpdateEntityAsync(AppUser user)
    {
        if (this.Fullname != null) user.FullName = this.Fullname;
        if (this.FromCity != null) user.FullName = this.FromCity;
        if (this.ImageFile != null)
        {
            user.ImagePath = await this.ImageFile.SaveFileAsync();
        }
    }
}
