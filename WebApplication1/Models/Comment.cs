namespace WebApplication1.Models;

public class Comment
{
    public int PostId { get; set; }
    public int CommentId { get; set; }
    public int UserId { get; set; }
    public string Content { get; set; }
    public DateTime DateTime { get; set; }

    public virtual Post Post { get; set; }
    public virtual User User { get; set; }
}