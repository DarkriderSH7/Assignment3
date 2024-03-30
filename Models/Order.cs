namespace Assignment3.Models;
public class Order
{
    public int OrderId { get; set; }
    public int UserId { get; set; }
    public List<Product> Products { get; set; }
    public decimal TotalPrice { get; set; } // Could also be calculated based on Product prices
    public DateTime OrderDate { get; set; }
    public string ShippingAddress { get; set; } // Could be different from User's default

    public User User { get; set; }
}
