using WebApplicationExam.Models;

namespace WebApplicationExam.Areas.Admin.ViewModels.SettingAVMs;

public class SettingAVM
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string BackImagePath { get; set; }

    public SettingAVM(Setting setting)
    {
        this.Id = setting.Id;
        this.CompanyName = setting.CompanyName;
        this.PhoneNumber = setting.PhoneNumber;
        this.Email = setting.Email;
        this.BackImagePath = setting.BackImagePath;
    }
}
