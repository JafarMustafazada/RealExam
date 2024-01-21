using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationExam.Areas.Admin.ViewModels.CommentAVMs;
using WebApplicationExam.Contexts;

namespace WebApplicationExam.Areas.Admin.Controllers;

[Area("Admin")]
public class CommentController : Controller
{
	Carvila01DbContext _context {  get; }


    public CommentController(Carvila01DbContext context)
    {
        this._context = context;
    }

    // GET: CommentController
    public ActionResult Index()
	{
		return View(this._context.Comments.Take(3).Select(c => new CommentAVM(c)));
	}
	// GET: CommentController/Create
	public ActionResult Create()
	{
		return View();
	}

	// POST: CommentController/Create
	[HttpPost]
	public ActionResult Create(CommentCreateAVM vm)
	{
		try
		{
			return RedirectToAction(nameof(Index));
		}
		catch
		{
			return View();
		}
	}

	// GET: CommentController/Edit/5
	public ActionResult Edit(int id)
	{
		return View();
	}

	// POST: CommentController/Edit/5
	[HttpPost]
	public ActionResult Edit(int id, CommentCreateAVM vm)
	{
		try
		{
			return RedirectToAction(nameof(Index));
		}
		catch
		{
			return View();
		}
	}

	// GET: CommentController/Delete/5
	public ActionResult Toggle(int id)
	{
		return View();
	}
}
