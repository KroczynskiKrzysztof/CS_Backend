namespace WebApplication1.Models.DTOs;

public class CommentDTO
{
    public int CommentId { get; set; }
    public string Content { get; set; }
    public string AuthorName { get; set; }
    public int AuthorId { get; set; }
}