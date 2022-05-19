
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CompleteProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}