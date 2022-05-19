using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Member
{
    [Key]
    [DisplayName("شناسه")]
    public int ID { get; set; }

    [DisplayName("تارخ عضویت")]
    public DateTime RegisterDate { get; private set; }

    [DisplayName("نام")]
    public string FirstName { get; set; }

    [DisplayName("نام خانوادگی")]
    public string LastName { get; set; }

    [DisplayName("جنسیت")]
    public SexEnum Sex { get; set; }

    [StringLength(10)]
    [DisplayName("کد ملی")]
    public string? SSID { get; set; }

    [DisplayName("شماره تلفن همراه")]
    public string? Mobile { get; set; }

    [DisplayName("تاریخ تولد")]
    public DateTime? BirthDate { get; set; }

    [DisplayName("نوع عضویت")]
    public SubscriptionTypeEnum SubscriptionType { get; set; }

    [DisplayName(displayName: "کتابهای در اختیار")]
    public List<Book> Books { get; set; } = new();

    [DisplayName("کتابخانه های عضو")]
    public List<Library> Libraries { get; set; }

    public bool IsActive { get; set; } = true;

    public Member()
    {
        RegisterDate = DateTime.Now;
    }
}