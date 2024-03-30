namespace Assignment3.Models;
public class Purchase
{
    public int PurchaseId { get; set; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public DateTime PurchaseDate { get; set; }

    public Product Product { get; set; }
}
