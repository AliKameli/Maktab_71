using System.ComponentModel;

namespace WebApplication1.Models;

public class MemberDTO
{
    [DisplayName("نام")]
    public string FirstName { get; set; }
    
    [DisplayName("نام خانوادگی")]
    public string LastName { get; set; }
    
    [DisplayName("جنسیت")]
    public SexEnum Sex { get; set; }
    
    [DisplayName("کد ملی")]
    public string? SSID { get; set; }
    
    [DisplayName("شماره تلفن همراه")]
    public string? Mobile { get; set; }
    
    [DisplayName("تاریخ تولد")]
    public DateTime? BirthDate { get; set; }
    
    [DisplayName("نوع عضویت")]
    public SubscriptionTypeEnum SubscriptionType { get; set; }
    

    public static explicit operator MemberDTO(Member v)
    {
        return new MemberDTO()
        {
            FirstName = v.FirstName, 
            LastName = v.LastName, 
            Sex = v.Sex, 
            Mobile = v.Mobile, 
            BirthDate = v.BirthDate,
            SSID = v.SSID, 
            SubscriptionType = v.SubscriptionType
        };
    }
}