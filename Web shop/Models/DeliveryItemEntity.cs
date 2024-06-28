using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Web_shop.Models
{
    public class DeliveryItemEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int DeliveryId { get; set; }

        [ForeignKey("DeliveryId")]
        public DeliveryEntity Delivery { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public ProductEntity Product { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
