using System.ComponentModel.DataAnnotations;

public class ProductEntity
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public int Quantity { get; set; }
    public decimal? CostPrice { get; set; }
    [Required]
    public decimal RetailPrice { get; set; }
    public int? MinimumStockLevel { get; set; }
    public int? SupplierId { get; set; }
    public SupplierEntity? Supplier { get; set; }
    public float? Weight { get; set; }
    public string? Dimensions { get; set; }
    public DateTime? ExpirationDate { get; set; }
    [Required]
    public bool IsActive { get; set; } = true;
    [Required]
    public int CategoryId { get; set; }
    [Required]
    public CategoryEntity Category { get; set; }

}