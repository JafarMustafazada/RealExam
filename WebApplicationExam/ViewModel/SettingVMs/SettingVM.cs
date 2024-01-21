using WebApplicationExam.Models;

namespace WebApplicationExam.ViewModel.SettingVMs;

public class SettingVM
{
    public string CompanyName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string BackImagePath { get; set; }

    public SettingVM(Setting setting)
    {
        this.CompanyName = setting.CompanyName;
        this.PhoneNumber = setting.PhoneNumber;
        this.Email = setting.Email;
        this.BackImagePath = setting.BackImagePath;
    }
}
