using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CompleteProject.Entities
{
    public class Manufacturer
    {
        [Key]
        [DisplayName("شناسه کارخانه")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("نام کارخانه")]
        public string Name { get; set; }

        [MaxLength(100)]
        [DisplayName("آدرس کارخانه")]
        public string? Address { get; set; }

        [MaxLength(30)]
        [DisplayName("شماره تلفن کارخانه")]
        public string? PhoneNumber { get; set; }

        public ICollection<Bill> Bills { get; set; }
    }
}
