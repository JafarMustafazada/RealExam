using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationExam.Areas.Admin.ViewModels.SettingAVMs;
using WebApplicationExam.Contexts;
using WebApplicationExam.Extensions;
using WebApplicationExam.Models;

namespace WebApplicationExam.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "SuperAdmin, Admin")]
public class SettingController : Controller
{
    Carvila01DbContext _context {  get; }

    public SettingController(Carvila01DbContext context)
    {
        _context = context;
    }

    // GET: SettingController
    public async Task<ActionResult> Index()
    {
        Setting setting = await this._context.Settings.FindAsync(1);
        return View(new SettingAVM(setting));
    }

    // GET: SettingController/Edit/5
    public async Task<ActionResult> Edit()
    {
        Setting setting = await this._context.Settings.FindAsync(1);
        return View(new SettingEditAVM(setting));
    }

    // POST: SettingController/Edit/5
    [HttpPost]
    public async Task<ActionResult> Edit(SettingEditAVM vm)
    {
        if (vm.BackImageFile != null && !vm.BackImageFile.IsContentType())
        {
            ModelState.AddModelError("", "No image provided");
        }
        if (vm.Email != null && !vm.Email.Contains('@')) ModelState.AddModelError("", "Wrong email");
        if (!ModelState.IsValid) return View(vm);

        Setting setting = await this._context.Settings.FindAsync(1);
        await vm.UpdateEntityAsync(setting);
        this._context.Settings.Update(setting);
        await this._context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }
}
