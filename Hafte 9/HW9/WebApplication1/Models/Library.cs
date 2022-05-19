using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Library
{
    [Key]
    [DisplayName("شناسه کتابخانه")]
    public int ID { get; set; }

    [DisplayName("نام کتابخانه")]
    public string Name { get; set; }

    [DisplayName("آدرس کتابخانه")]
    public string? Address { get; set; }

    [DisplayName("شهر کتابخانه")]
    public City City { get; set; }

    [DisplayName("کتابهای کتابخانه")]
    public List<Book> Books { get; set; } = new();

    public bool IsActive { get; set; } = true;
    
}