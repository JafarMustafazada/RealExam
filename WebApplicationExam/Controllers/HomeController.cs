using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplicationExam.Contexts;
using WebApplicationExam.Models;
using WebApplicationExam.ViewModel.CommentVMs;

namespace WebApplicationExam.Controllers
{
    public class HomeController : Controller
    {
        Carvila01DbContext _context { get; }

        public HomeController(Carvila01DbContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            return View(this._context.Comments.Where(c => c.IsActive).Take(4).Include(c => c.AppUser).
                Select(c => new CommentVM(c)));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
