using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Webshop.Models;

public class Product
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [DisplayName("Product Description")]
    public string Description { get; set; } = string.Empty;

    [Range(1, 100)]
    public decimal Price { get; set; }


    public DateTime PackingDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public byte[] Image { get; set; } = null!;
}