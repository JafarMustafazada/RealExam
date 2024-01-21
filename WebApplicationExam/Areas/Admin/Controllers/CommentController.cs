using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationExam.Areas.Admin.ViewModels.CommentAVMs;
using WebApplicationExam.Contexts;
using WebApplicationExam.Models;

namespace WebApplicationExam.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "SuperAdmin, Admin")]
public class CommentController : Controller
{
    Carvila01DbContext _context { get; }
    Comment _entity;
    DbSet<Comment> _entities;

    public CommentController(Carvila01DbContext context)
    {
        this._context = context;
        this._entities = this._context.Comments;
    }

    async Task<bool> CheckIdAsync(int id)
    {
        this._entity = await this._entities.FindAsync(id);
        return this._entity != null;
    }

    // GET: CommentController
    public ActionResult Index()
    {
        return View(this._entities.Take(3).Include(e => e.AppUser).
            Select(c => new CommentAVM(c)));
    }
    // GET: CommentController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: CommentController/Create
    [HttpPost]
    public async Task<ActionResult> Create(CommentCreateAVM vm)
    {
        if (!ModelState.IsValid) return View(vm);

        Comment comment = vm.ToEntity();
        comment.AppUserId = (await this._context.AppUsers.FirstAsync(u => u.UserName == User.Identity.Name)).Id;

        await this._entities.AddAsync(comment);
        await this._context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    // GET: CommentController/Edit/5
    public async Task<ActionResult> Edit(int id)
    {
        if (!await this.CheckIdAsync(id)) return NotFound();
        return View(new CommentEditAVM(this._entity));
    }

    // POST: CommentController/Edit/5
    [HttpPost]
    public async Task<ActionResult> Edit(int id, CommentEditAVM vm)
    {
        if (!await this.CheckIdAsync(id)) return NotFound();
        if (!ModelState.IsValid) return View(vm);

        vm.UpdateEntity(this._entity);
        this._entities.Update(this._entity);
        await this._context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    // GET: CommentController/Delete/5
    public async Task<ActionResult> Toggle(int id)
    {
        if (!await this.CheckIdAsync(id)) return NotFound();

        this._entity.IsActive = !this._entity.IsActive;
        this._entities.Update(this._entity);
        await this._context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }
}
