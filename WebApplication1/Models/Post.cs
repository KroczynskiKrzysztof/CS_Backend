namespace WebApplication1.Models;

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime DateTime { get; set; }
    public int UserId { get; set; }
    public int State { get; set; }

    public virtual User Author { get; set; }
    public virtual ICollection<Comment> Comments { get; set; }
    public virtual ICollection<PostTag> PostTags { get; set; }
}