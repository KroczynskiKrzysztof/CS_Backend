namespace WebApplication1.Models;

public class PostTag
{
    public int PostID { get; set; }
    public int TagID { get; set; }

    public virtual Post Post { get; set; }
    public virtual Tag Tag { get; set; }
}