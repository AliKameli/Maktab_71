using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Web;

namespace WebApplication1.Models;

public class Book
{
    [Key]
    [DisplayName("شناسه")]
    public int ID { get; set; }
    
    
    [DisplayName("نام کتاب")]
    public string Title { get; set; }
    
    
    [DisplayName("نویسنده")]
    public string Writer { get; set; }


    public bool IsActive { get; set; } = true;
}