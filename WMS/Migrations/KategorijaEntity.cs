using System.ComponentModel.DataAnnotations;

public class KategorijaEntity
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public Boolean IsActive { get; set; }
}
