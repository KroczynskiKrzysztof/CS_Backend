using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.DTOs;

namespace WebApplication1.Services;

public interface IDbService
{
    Task<User?> GetUserByUsernameAndPassword(string username, string password);
    Task<User> CreateUser(User user);

    Task<bool> ValidateNewUsername(string username);

    Task<ICollection<RoleDTO>> getRoles();

    Task<string?> GetRoleById(int roleId);
    Task ChangePassword(User user, string newPassword);
    Task<PaginatedResult<PostTitleDTO>> GetPaginatedPosts(int pageNumber, int pageSize,string role);
    Task<PostDetailsDTO>? GetPostDetails(int id);
    Task<PaginatedResult<PostTitleDTO>?> GetPaginatedPosts(int pageNumber, int pageSize, int tagId,string role);
    Task<Post> AddNewPost(NewPostRequest newPostRequest, int userId );
    Task<Comment> AddComment(CommentDTO2 commentDto2, int userId);
    Task<bool> DeleteComment(int commentId);
    Task<bool> DeletePostTag(TagDeleteRequest tagDeleteRequest);
    Task<bool> AddPostTag(TagAddRequest tagAddRequest);
    Task<bool> ValidateDisplayName(string displayName);

    void Nuke();
    Task<bool> HidePost(int postId, int i);
    Task EraseUser(int idDtoId);
    bool ValidateUser(int userId);
}