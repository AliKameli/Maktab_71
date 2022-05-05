using System.ComponentModel;

namespace WebApplication1.Models;

public class Member
{
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

    [DisplayName("کد ملی")]
    public string SSID { get; set; }

    [DisplayName("شماره تلفن همراه")]
    public string Mobile { get; set; }

    [DisplayName("تاریخ تولد")]
    public DateTime BirthDate { get; set; }

    [DisplayName("نوع عضویت")]
    public SubscriptionTypeEnum SubscriptionType { get; set; }


    public Member()
    {
        RegisterDate = DateTime.Now;
    }
    
}