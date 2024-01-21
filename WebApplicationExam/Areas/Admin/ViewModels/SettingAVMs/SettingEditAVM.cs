using WebApplicationExam.Extensions;
using WebApplicationExam.Models;

namespace WebApplicationExam.Areas.Admin.ViewModels.SettingAVMs;

public class SettingEditAVM
{
    public string? CompanyName { get; set; } 
    public string? PhoneNumber { get; set; } 
    public string? Email { get; set; }
    public string? BackImagePath { get; set; }
    public IFormFile? BackImageFile { get; set; }

    public SettingEditAVM() { }

    public SettingEditAVM(Setting setting)
    {
        this.CompanyName = setting.CompanyName;
        this.PhoneNumber = setting.PhoneNumber;
        this.Email = setting.Email;
        this.BackImagePath = setting.BackImagePath;
    }

    public async Task UpdateEntityAsync(Setting setting)
    {
        if (this.Email != null) setting.Email = this.Email;
        if (this.CompanyName != null) setting.CompanyName = this.CompanyName;
        if (this.PhoneNumber != null) setting.PhoneNumber = this.PhoneNumber;
        if (this.BackImageFile != null) setting.BackImagePath = await this.BackImageFile.SaveFileAsync();
    }
}
