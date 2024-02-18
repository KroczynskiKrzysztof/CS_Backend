using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.DTOs;

namespace WebApplication1.Services;

public class DbService : IDbService
{
    private AppDbContext _appDbContext;
    private PasswordHasher _passwordHasher;

    public DbService(AppDbContext appDbContext, PasswordHasher passwordHasher)
    {
        _appDbContext = appDbContext;
        _passwordHasher = passwordHasher;
    }

    public async Task<User?> GetUserByUsernameAndPassword(string username, string password)
    {
        return await _appDbContext.Users.FirstOrDefaultAsync(user =>
            user.Username == username && user.Password == _passwordHasher.HashPassword(password));
    }

    public async Task<User> CreateUser(User user)
    {
        await _appDbContext.Users.AddAsync(user);
        await _appDbContext.SaveChangesAsync();
        return user;
    }

    public async Task<bool> ValidateNewUsername(string username)
    {
        return await _appDbContext.Users.CountAsync(user => user.Username == username) > 0;
    }

    public async Task<ICollection<RoleDTO>> getRoles()
    {
        return await _appDbContext.Roles.Select(role => new RoleDTO { RoleId = role.Id, Name = role.Name })
            .ToListAsync();
    }

    public async Task<string?> GetRoleById(int roleId)
    {
        return await _appDbContext.Roles.Where(role => roleId == role.Id).Select(role => role.Name)
            .FirstOrDefaultAsync();
    }

    public async Task ChangePassword(User user, string newPassword)
    {
        user.Password = _passwordHasher.HashPassword(newPassword);
        await _appDbContext.SaveChangesAsync();
    }

    public async Task<PaginatedResult<PostTitleDTO>> GetPaginatedPosts(int pageNumber, int pageSize, string role)
    {
        Dictionary<string, int> rolePostState = new Dictionary<string, int>()
        {
            { "Admin", 3 },
            { "Mod", 2 },
            { "User", 1 }
        };


        var totalItems = _appDbContext.Posts.Where(post => post.State < rolePostState[role]).Count();


        var paginatedPostTitles = await _appDbContext.Posts
            .Where(post => post.State < rolePostState[role])
            .OrderByDescending(post => post.DateTime)
            .Skip(pageNumber * pageSize)
            .Take(pageSize).Select(post => new PostTitleDTO()
            {
                Title = post.Title,
                AuthorName = post.Author.DisplayName,
                PostId = post.PostId,
                Tags = post.PostTags.Select(tag => new TagDTO() { TagId = tag.TagID, TagName = tag.Tag.Name }).ToList(),
                DateTime = post.DateTime,
                PostState = post.State
            }).ToListAsync();

        return new PaginatedResult<PostTitleDTO>
        {
            PageNumber = pageNumber,
            PageSize = pageSize,
            TotalItems = totalItems,
            Items = paginatedPostTitles,
            TotalPages = (int)Math.Ceiling((double)totalItems / pageSize)
        };
    }


    public async Task<PostDetailsDTO>? GetPostDetails(int id)
    {
        return (await _appDbContext.Posts.Where(post => post.PostId == id).Select(post => new PostDetailsDTO()
        {
            AuthorId = post.UserId, AuthorName = post.Author.DisplayName, Content = post.Content, PostId = post.PostId, Title = post.Title,
            Comments = post.Comments.OrderByDescending(post1 => post1.DateTime)
                .Select(comment => new CommentDTO()
                    { AuthorName = comment.User.DisplayName, Content = comment.Content, CommentId = comment.CommentId, AuthorId = comment.UserId})
                .ToList(),
            Tags = post.PostTags.Select(tag => tag.Tag)
                .Select(tag => new TagDTO() { TagId = tag.TagId, TagName = tag.Name }).ToList()
        }).FirstOrDefaultAsync())!;
    }

    public async Task<PaginatedResult<PostTitleDTO>?> GetPaginatedPosts(int pageNumber, int pageSize, int tagId,
        string role)
    {
        Dictionary<string, int> rolePostState = new Dictionary<string, int>()
        {
            { "Admin", 3 },
            { "Mod", 2 },
            { "User", 1 }
        };

        var totalItems = _appDbContext.Posts.Where(post => post.PostTags.Any(tag => tag.TagID == tagId))
            .Where(post => post.State < rolePostState[role]).Count();

        if (pageNumber * pageSize > totalItems)
        {
            pageNumber = (int)Math.Floor((double)totalItems / pageSize);
        }

        var paginatedPostTitles = await _appDbContext.Posts
            .Where(post => post.State < rolePostState[role])
            .OrderByDescending(post => post.DateTime)
            .Where(post => post.PostTags.Any(tag => tag.TagID == tagId))
            .Skip(pageNumber * pageSize)
            .Take(pageSize).Select(post => new PostTitleDTO()
            {
                PostId = post.PostId,
                Title = post.Title,
                AuthorName = post.Author.DisplayName,
                Tags = post.PostTags.Select(tag => new TagDTO() { TagId = tag.TagID, TagName = tag.Tag.Name }).ToList(),
                DateTime = post.DateTime,
                PostState = post.State
            }).ToListAsync();

        return new PaginatedResult<PostTitleDTO>
        {
            PageNumber = pageNumber,
            PageSize = pageSize,
            TotalItems = totalItems,
            Items = paginatedPostTitles,
            TotalPages = (int)Math.Ceiling((double)totalItems / pageSize)
        };
    }

    public async Task<Post> AddNewPost(NewPostRequest newPostRequest, int userId)
    {
        Post post = new Post()
        {
            Title = newPostRequest.Title, Content = newPostRequest.Content,
            Author = await _appDbContext.Users.FirstOrDefaultAsync(user => user.UserId == userId),
            DateTime = DateTime.Now
        };
        await _appDbContext.Posts.AddAsync(post);
        await _appDbContext.SaveChangesAsync();
        var tags = newPostRequest.TagNames.Split().Select(t => t.Trim()).Where(s => !string.IsNullOrWhiteSpace(s))
            .Distinct().ToList();
        foreach (var variable in tags)
        {
            _appDbContext.PostTags.Add(new PostTag() { PostID = post.PostId, TagID = await GetTagId(variable.Trim()) });
        }

        await _appDbContext.SaveChangesAsync();

        return post;
    }

    public async Task<Comment> AddComment(CommentDTO2 commentDto2, int userId)
    {
        Comment comment = new Comment()
            { PostId = commentDto2.PostId, Content = commentDto2.Content, UserId = userId, DateTime = DateTime.Now };
        await _appDbContext.Comments.AddAsync(comment);
        await _appDbContext.SaveChangesAsync();
        return comment;
    }

    public async Task<bool> DeleteComment(int commentId)
    {
        Comment? c = await _appDbContext.Comments.FirstOrDefaultAsync(comment => comment.CommentId == commentId);
        if (c is null)
        {
            return false;
        }

        _appDbContext.Comments.Remove(c);
        await _appDbContext.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeletePostTag(TagDeleteRequest tagDeleteRequest)
    {
        PostTag? postTag = await _appDbContext.PostTags.FirstOrDefaultAsync(tag =>
            tag.TagID == tagDeleteRequest.TagId && tag.PostID == tagDeleteRequest.Postid);
        if (postTag is null)
        {
            return false;
        }

        _appDbContext.PostTags.Remove(postTag);
        await _appDbContext.SaveChangesAsync();
        return true;
    }

    public async Task<bool> AddPostTag(TagAddRequest tagAddRequest)
    {
        Post? post = await _appDbContext.Posts.Include(post1 => post1.PostTags)
            .FirstOrDefaultAsync(post1 => post1.PostId == tagAddRequest.PostId);
        if (post is null)
        {
            return false;
        }

        int tagId = await GetTagId(tagAddRequest.TagName);

        if (post.PostTags.Count(tag => tag.TagID == tagId) > 0)
        {
            return false;
        }

        _appDbContext.PostTags.Add(new PostTag() { PostID = post.PostId, TagID = tagId });
        await _appDbContext.SaveChangesAsync();
        return true;
    }

    public async Task<bool> ValidateDisplayName(string displayName)
    {
        return await _appDbContext.Users.FirstOrDefaultAsync(user => user.DisplayName == displayName) is not null;
    }

    public void Nuke()
    {
        _appDbContext.Posts.RemoveRange(_appDbContext.Posts);
        _appDbContext.Tags.RemoveRange(_appDbContext.Tags);
    }

    public async Task<bool> HidePost(int postId, int i)
    {
        var post = await _appDbContext.Posts.FirstOrDefaultAsync(post => post.PostId == postId);
        if (post is null)
        {
            return false;
        }
        post.State = i;
        await _appDbContext.SaveChangesAsync();
        return true;
    }

    public async Task EraseUser(int idDtoId)
    {
        var user = await _appDbContext.Users.FirstOrDefaultAsync(user1 => user1.UserId == idDtoId);
        _appDbContext.Comments.RemoveRange(_appDbContext.Comments.Where(comment => comment.UserId==idDtoId).ToList());

        var posts = _appDbContext.Posts.Where(post => post.UserId == idDtoId).Include(post => post.PostTags).Include(post => post.Comments).ToList();
        foreach (var post in posts)
        {
            foreach (var postComment in post.Comments)
            {
                post.Comments.Remove(postComment);
            }

            foreach (var postPostTag in post.PostTags)
            {
                post.PostTags.Remove(postPostTag);
            }

            _appDbContext.Posts.Remove(post);
        }   
        
        _appDbContext.Users.Remove(user!);
        await _appDbContext.SaveChangesAsync();
    }

    public bool ValidateUser(int userId)
    {
        return _appDbContext.Users.FirstOrDefaultAsync(user => user.UserId == userId) is null;
    }


    private async Task<int> GetTagId(string tagName)
    {
        var tag = await _appDbContext.Tags
            .Where(tag => tag.Name == char.ToUpper(tagName[0]) + tagName.Substring(1).ToLower()).FirstOrDefaultAsync();
        if (tag is null)
        {
            tag = new Tag() { Name = char.ToUpper(tagName[0]) + tagName.Substring(1).ToLower() };
            await _appDbContext.Tags.AddAsync(tag);
            await _appDbContext.SaveChangesAsync();
        }

        return tag.TagId;
    }
}