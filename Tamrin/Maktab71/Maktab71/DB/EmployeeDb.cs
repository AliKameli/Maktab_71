using Maktab71.Models;

namespace Maktab71.DB;

public class EmployeeDb
{
    // public static List<Employee> Employees=new List<Employee>()
    //Repository Local - in memory
    private static List<Employee> _employees = new List<Employee>
    {
        new Employee
        {
            Age = 28,
            Name = "Sadra",
            Family = "Daviran",
            Id = Guid.NewGuid(),
            Mobile = "09125478475",
            NationalCode = "0087541474"
        },
        new Employee
        {
            Age = 36,
            Name = "Mahdi",
            Family = "Mollaeian",
            Id = Guid.NewGuid(),
            Mobile = "09125478475",
            NationalCode = "0087541474"
        },
        new Employee
        {
            Age = 24,
            Name = "Ali",
            Family = "Kameli",
            Id = Guid.NewGuid(),
            Mobile = "09125478475",
            NationalCode = "0087541474"
        },
    };

    public static List<Employee> GetAll()
    {
        return _employees;
    }

    public static Employee GetById(Guid id)
    {
        return _employees.FirstOrDefault(x => x.Id == id);
    }

    public static bool Delete(Guid id)
    {
        var emp = _employees.FirstOrDefault(x => x.Id == id);
        return _employees.Remove(emp);
    }

    public static Guid Add(EmployeeSaveDTO model)
    {
        var emp = new Employee();
        emp.RegisterDate=DateTimeOffset.Now;
        emp.Id = Guid.NewGuid();
        
        emp.Name = model.Name;
        emp.Family = model.Family;
        emp.Age = model.Age;
        emp.Mobile = model.Mobile;
        emp.NationalCode = model.NationalCode;
        _employees.Add(emp);
        return emp.Id;
    }
}