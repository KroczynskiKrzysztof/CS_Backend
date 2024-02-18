namespace WebApplication1.Models.DTOs;

public class PostDetailsDTO
{
    public string AuthorName { get; set; }
    public int AuthorId { get; set; }
    public string Title { get; set; }
    public int PostId { get; set; }
    public string Content { get; set; }
    public ICollection<TagDTO> Tags { get; set; }
    public ICollection<CommentDTO> Comments { get; set; }

}