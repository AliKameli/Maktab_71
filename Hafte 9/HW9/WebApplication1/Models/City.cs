using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class City
{
    [Key]
    [DisplayName("شناسه شهر")]
    public int ID { get; set; }
    
    
    [DisplayName("نام شهر")] 
    public string Name { get; set; }
}
