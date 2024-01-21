using WebApplicationExam.ViewModel.SettingVMs;

namespace WebApplicationExam.Services.Interfaces;

public interface ILayoutService
{
    Task<SettingVM> GetSettingsAsync();
}
