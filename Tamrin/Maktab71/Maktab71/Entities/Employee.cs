using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Maktab71;

public class Employee
{
    [DisplayName("کد شناسایی")]
    public Guid Id { get; set; }
    [DisplayName("نام")]
    public string Name { get; set; }
    [DisplayName("نام خانوادگی")]
    public string Family { get; set; }
    [DisplayName("سن")]
    public int Age { get; set; }
    [DisplayName("کد ملی")]
    public string NationalCode { get; set; }
    [DisplayName("شماره تلفن")]
    public string Mobile { get; set; }
    [DisplayName("تاریخ ثبت نام")]
    public DateTimeOffset RegisterDate { get; set; }
    [DisplayName("تاریخ تغییر")]
    public DateTimeOffset ModifyDate { get; set; }
}