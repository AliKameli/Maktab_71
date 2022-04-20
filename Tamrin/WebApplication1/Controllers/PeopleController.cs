using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using static DataStore;

namespace WebApplication1.Controllers
{
    public class PeopleController : Controller
    {
        IPersonRepository _personRepository = new PersonRepository();
        public IActionResult Index()
        {
            //_personRepository.Add(new Person("0022425632", "Ali", "Kameli"));
            //_personRepository.Add(new Person("05123854", "Amin", "Javadi"));
            //_personRepository.SaveFile();
            _personRepository.LoadFile();
            var people = _personRepository.GetAll();
            
            return View(people);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Read()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
