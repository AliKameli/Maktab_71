using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace CompleteProject.Controllers
{
    public class LibraryController : Controller
    {
        private readonly DataRepo repo = new DataRepo();
        public IActionResult Index()
        {
            var model = repo.Libraries.Include(x => x.Books).Include(x => x.Members).Include(x=>x.City).ToList();
            return View(model);
        }
        public IActionResult SearchById(int? id)
        {
            if (id == null || id == 0)
                return RedirectToAction("Index");
            var model = repo.Libraries.Include(x => x.Books).Include(x => x.Members).Include(x => x.City).Where(x => x.Id == id).ToList();
            return View("Index", model);
        }
        public IActionResult SearchByName(string? name)
        {
            if (name == null)
                return RedirectToAction("Index");
            var model = repo.Libraries.Include(x => x.Books).Include(x => x.Members).Include(x => x.City).Include(x=>x.City).Where(x => x.Name.Contains(name)).ToList();
            return View("Index", model);
        }
        public IActionResult SearchByMember(string? name)
        {
            if (name == null)
                return RedirectToAction("Index");
            var model = repo.Libraries.Include(x => x.Books).Include(x => x.Members).Include(x => x.City).Where(x => x.Members.Any(y => y.FirstName.Contains(name) || y.LastName.Contains(name))).ToList();
            return View("Index", model);
        }
        public IActionResult SearchByAddress(string? name)
        {
            if (name == null)
                return RedirectToAction("Index");
            var model = repo.Libraries.Include(x => x.Books).Include(x => x.Members).Include(x => x.City).Where(x => x.Address.Contains(name)||x.City.Name.Contains(name)).ToList();
            return View("Index", model);
        }
        public IActionResult SearchByBorrowedBooks(string? name)
        {
            if (name == null)
                return RedirectToAction("Index");
            var model = repo.Libraries.Include(x => x.Books).Include(x => x.Members).Include(x => x.City).Where(x => x.Books.Any(y => y.IsBorrowed && y.Title.Contains(name))).ToList();
            return View("Index", model);
        }
    }
}
