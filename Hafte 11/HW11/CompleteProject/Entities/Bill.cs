using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompleteProject.Entities
{
    public class Bill
    {
        [Key]
        [DisplayName("شناسه فاکتور")]
        public int Id { get; set; }

        [ForeignKey("Buyer")]
        [DisplayName("شناسه خریدار")]
        public int BuyerId { get; set; }

        [DisplayName("خریدار")]
        public Buyer Buyer { get; set; }

        [ForeignKey("Seller")]
        [DisplayName("شناسه فروشنده")]
        public int SellerId { get; set; }

        [DisplayName("فروشنده")]
        public Seller Seller { get; set; }

        [ForeignKey("Shop")]
        [DisplayName("شناسه فروشگاه")]
        public int ShopId { get; set; }

        [DisplayName("فروشگاه")]
        public Shop Shop { get; set; }

        [DisplayName("کارخانه‌ها")]
        public ICollection<Manufacturer> Manufacturers { get; set; }

        [DisplayName("قیمت")]
        public float Price { get; set; }

    }
}
