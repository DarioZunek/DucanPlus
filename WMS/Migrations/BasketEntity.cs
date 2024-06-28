public class BasketEntity
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public List<BasketItemEntity> Items { get; set; } = new List<BasketItemEntity>();
}