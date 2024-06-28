using System.ComponentModel.DataAnnotations;

public class SupplierEntity
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public bool IsActive { get; set; } = true;
    public ICollection<ProductEntity>? Products { get; set; }

    public SupplierEntity()
    {
        Products = new HashSet<ProductEntity>();
    }
}
