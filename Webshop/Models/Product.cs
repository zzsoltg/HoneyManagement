using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webshop.Models;

public class Product
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MinLength(3)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [MinLength(10)]
    public string Description { get; set; } = string.Empty;

    [Range(1, 100)]
    public decimal Price { get; set; }

    [DisplayName("Packing Date")]
    public DateTime PackingDate { get; set; }
    [DisplayName("Expiration Date")]
    public DateTime ExpirationDate { get; set; }
    public byte[] Image { get; set; } = null!;
    [NotMapped]
    public IFormFile NewImage { get; set; } = null!;
}
