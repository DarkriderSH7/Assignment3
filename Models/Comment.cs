namespace Assignment3.Models;
public class Comment
{
    public int CommentId { get; set; }
    public int ProductId { get; set; }
    public int UserId { get; set; }
    public int Rating { get; set; }
    public List<string> ImageUrls { get; set; }
    public string Text { get; set; }

    public Product Product { get; set; }
    public User User { get; set; }
}