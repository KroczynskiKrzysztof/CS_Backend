namespace WebApplication1.Models.DTOs;

public class PostTitleDTO
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string AuthorName { get; set; }
    public DateTime DateTime { get; set; }
    public int PostState { get; set; }
    public ICollection<TagDTO> Tags { get; set; }
}