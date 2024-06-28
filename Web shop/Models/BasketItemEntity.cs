namespace Web_shop.Models
{
    public class BasketItemEntity
    {
        public int Id { get; set; }
        public int BasketId { get; set; }
        public BasketEntity Basket { get; set; }
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; }

        public int Quantity { get; set; }
        public decimal RetailPrice { get; set; }
    }
}