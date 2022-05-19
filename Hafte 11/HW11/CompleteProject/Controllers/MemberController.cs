using CompleteProject.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CompleteProject.Controllers
{
    public class MemberController : Controller
    {
        private readonly DataRepo repo = new DataRepo();
        public IActionResult Index()
        {
            var model = repo.Members.ToList();
            return View(model);
        }



        public IActionResult Detail(int id)
        {
            var member = repo.Members.SingleOrDefault(x => x.Id == id);
            return View(member);
        }



        public IActionResult Remove(int id)
        {
            repo.Members.Remove(repo.Members.SingleOrDefault(x => x.Id == id));
            repo.SaveChanges();
            return RedirectToAction("Index");
        }





        [HttpGet]
        public IActionResult Add()
        {
            var model = new Member();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(Member model)
        {

            repo.Members.Add(new Member
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                SSID = model.SSID,
                Mobile = model.Mobile,
                BirthDate = model.BirthDate,
                SubscriptionType = model.SubscriptionType,
                Gender = model.Gender,
            });
            repo.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var model = repo.Members.SingleOrDefault(x => x.Id == id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Member model, int id)
        {
            var result = repo.Members.SingleOrDefault(x => x.Id == id);
            result.FirstName = model.FirstName;
            result.LastName = model.LastName;
            result.SSID = model.SSID;
            result.Mobile = model.Mobile;
            result.BirthDate = model.BirthDate;
            result.SubscriptionType = model.SubscriptionType;
            result.Gender = model.Gender;
            repo.SaveChanges();
            return RedirectToAction("Index");
        }




        public IActionResult Search(string? name)
        {
            if (name == null)
                return RedirectToAction("Index");
            var model = repo.Members.ToList().Where(x => x.FirstName.Contains(name) || x.LastName.Contains(name)).ToList();
            return View("Index", model);
        }
    }
}
