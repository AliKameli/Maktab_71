using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CompleteProject.Entities
{
    public class Shop
    {
        [Key]
        [DisplayName("شناسه فروشگاه")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("نام فروشگاه")]
        public string Name { get; set; }

        [MaxLength(100)]
        [DisplayName("آدرس فروشگاه")]
        public string? Address { get; set; }

        [MaxLength(30)]
        [DisplayName("شماره تلفن فروشگاه")]
        public string? PhoneNumber { get; set; }
    }
}
