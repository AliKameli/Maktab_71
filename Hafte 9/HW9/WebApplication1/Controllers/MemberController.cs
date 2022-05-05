using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class MemberController : Controller
{
    public IActionResult Index()
    {
        var model = MemberDB.GetAll();
        return View(model);
    }



    public IActionResult Detail(int id)
    {
        var member = MemberDB.GetById(id);
        return View(member);
    }



    public IActionResult Remove(int id)
    {
        MemberDB.DeleteById(id);
        return RedirectToAction("Index");
    }




    [HttpPost]
    public IActionResult Add(MemberDTO model)
    {
        var result = MemberDB.Add(model);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Add()
    {
        var model = new MemberDTO();
        return View(model);
    }



    [HttpPost]
    public IActionResult Update(MemberDTO model, int id)
    {
        var result = MemberDB.UpdateById(id,model);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        var model = (MemberDTO) MemberDB.GetById(id);
        return View(model);
    }



    public IActionResult Search(string? name)
    {
        if (name == null) 
            return RedirectToAction("Index");
        var model = MemberDB.GetAll().Where(x => x.FirstName.Contains(name) || x.LastName.Contains(name)).ToList();
        return View("Index", model);
    }
}