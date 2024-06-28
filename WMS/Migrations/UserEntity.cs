using System.ComponentModel.DataAnnotations;

public class UserEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(30)]
    public string Name { get; set; }

    [Required]
    [MaxLength(30)]
    public string Surname { get; set; }

    [Required]
    [MaxLength(30)]
    public string Username { get; set; }

    [Required]
    [MaxLength(100)]
    public string PasswordHash { get; set; }

    [Required]
    [MaxLength(100)]
    public string PasswordSalt { get; set; }

    [Required]
    [MaxLength(30)]
    public string Email { get; set; }

    [Required]
    public DateTime DateOfBirth { get; set; }

    [Required]
    public int RoleId { get; set; }

    [Required]
    public RoleEntity Role { get; set; }

    public bool IsActive { get; set; } = true; 

}