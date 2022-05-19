using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompleteProject.Entities;

public class Library
{
    [Key]
    [DisplayName("شناسه کتابخانه")]
    public int Id { get; set; }

    [Required]
    [DisplayName("نام کتابخانه")]
    [MaxLength(100)]
    public string Name { get; set; }

    [Required]
    [DisplayName("آدرس کتابخانه")]
    [MaxLength(255)]
    public string? Address { get; set; }

    [ForeignKey("City")]
    [DisplayName("شناسه شهر کتابخانه")]
    public int CityId { get; set; }

    [DisplayName("شهر کتابخانه")]
    public City City { get; set; }

    [DisplayName("کتاب‌های کتابخانه")]
    public ICollection<Book> Books { get; set; }

    [DisplayName("اعضای کتابخانه")]
    public ICollection<Member> Members { get; set; }

    [Required]
    public bool IsActive { get; set; } = true;

}