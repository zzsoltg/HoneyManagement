using System.Drawing;

namespace Common.Model;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public float Price { get; set; }
    public DateTime PackingDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public Image Image { get; set; } = null!;
}
