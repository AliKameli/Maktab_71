using Maktab71.DB;
using Maktab71.Models;
using Microsoft.AspNetCore.Mvc;

namespace Maktab71.Controllers;

public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    public IActionResult List()
    {
        var employees = EmployeeDb.GetAll();
        return View(employees);
    }

    public IActionResult Detail(Guid id)
    {
        var employee = (EmployeeSaveDTO)EmployeeDb.GetById(id);
        return View(employee);
    }

    public IActionResult Remove(Guid id)
    {
        var result = EmployeeDb.Delete(id);
        if (result) return RedirectToAction("List");
        return View("Error");
    }

    public string MultiParameter(string name,Guid id,string lastName)
    {
        return $"{name} {id.ToString()}";
    }

    [HttpPost]
    public IActionResult Add(EmployeeSaveDTO model)
    {
        var result = EmployeeDb.Add(model);
        return RedirectToAction("List");
    }

    [HttpGet]
    public IActionResult Add()
    {
        var model = new EmployeeSaveDTO();
        return View(model);
    }
    
}