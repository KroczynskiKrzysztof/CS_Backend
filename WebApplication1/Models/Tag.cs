namespace WebApplication1.Models;

public class Tag
{
    public int TagId { get; set; }
    public string Name { get; set; }

    public virtual ICollection<PostTag> PostTags{ get; set; }
}