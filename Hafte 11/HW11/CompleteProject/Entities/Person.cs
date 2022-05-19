using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace CompleteProject.Entities
{
    public abstract class Person
    {
        [Key]
        [DisplayName("شناسه شخص")]
        public int Id { get; set; }

        [Required]
        [DisplayName("تارخ عضویت شخص")]
        public DateTimeOffset RegisterDate { get; set; }=DateTimeOffset.Now;

        [Required]
        [MaxLength(100)]
        [DisplayName("نام")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("نام خانوادگی")]
        public string LastName { get; set; }

        [DisplayName("جنسیت")]
        public GenderEnum Gender { get; set; }

        [StringLength(10)]
        [DisplayName("کد ملی")]
        public string? SSID { get; set; }

        [MaxLength(30)]
        [DisplayName("شماره تلفن همراه")]
        public string? Mobile { get; set; }

        [DisplayName("تاریخ تولد")]
        public DateTimeOffset BirthDate { get; set; }
    }
}
