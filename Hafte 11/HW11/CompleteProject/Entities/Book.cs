using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Components.Web;

namespace CompleteProject.Entities;

public class Book
{
    [Key]
    [DisplayName("شناسه کتاب")]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(100)]
    [DisplayName("نام کتاب")]
    public string Title { get; set; }

    [Required]
    [MaxLength(100)]
    [DisplayName("نویسنده کتاب")]
    public string Writer { get; set; }

    public bool IsBorrowed { get; set; } = false;

	[ForeignKey("Member")]
	public int? MemberId { get; set; }

	public Member? Member { get; set; }

	[Required]
    public bool IsActive { get; set; } = true;

    


}