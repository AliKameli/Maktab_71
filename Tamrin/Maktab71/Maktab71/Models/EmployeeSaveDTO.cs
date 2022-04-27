using System.ComponentModel;

namespace Maktab71.Models;

public record class  EmployeeSaveDTO
{
    [DisplayName("نام")]
    public string Name { get; set; }
    [DisplayName("نام خانوادگی")]
    public string Family { get; set; }
    [DisplayName("سن")]
    public int Age { get; set; }
    [DisplayName("کد ملی")]
    public string NationalCode { get; set; }
    [DisplayName("شماره تلفن همراه")]
    public string Mobile { get; set; }

    public static explicit operator EmployeeSaveDTO(Employee v)
    {
        return new EmployeeSaveDTO() { Name = v.Name, Family = v.Family, Age = v.Age, NationalCode = v.NationalCode, Mobile = v.Mobile };
    }
}