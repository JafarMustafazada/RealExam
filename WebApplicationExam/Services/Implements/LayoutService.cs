using WebApplicationExam.Contexts;
using WebApplicationExam.Services.Interfaces;
using WebApplicationExam.ViewModel.SettingVMs;

namespace WebApplicationExam.Services.Implements;

public class LayoutService : ILayoutService
{
    Carvila01DbContext _context {  get; }

    public LayoutService(Carvila01DbContext context)
    {
        _context = context;
    }

    public async Task<SettingVM> GetSettingsAsync()
    {
        return new SettingVM(await this._context.Settings.FindAsync(1));
    }
}
