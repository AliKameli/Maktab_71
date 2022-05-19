using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CompleteProject.Entities;

public class City
{
    [Key]
    [DisplayName("شناسه شهر")]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    [DisplayName("نام شهر")] 
    public string Name { get; set; }

    [Required]
    public bool IsActive { get; set; } = true;
}
