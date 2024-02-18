namespace WebApplication1.Models;

public class User
{
    public int UserId { get; set; }
    public string DisplayName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public int Roleid { get; set; }
    public bool PrefEng { get; set; }

    public virtual Role Role { get; set; }
    public virtual ICollection<Post> Posts { get; set; }
    public virtual ICollection<Comment> Comments{ get; set; }

    // public static User Of(string login, string rawPassword, string displayName, int modelRoleId, bool prefEng)
    // {
    //     User user = new User();
    //     string hashedPassword = PasswordHasher.PasswordHasher.HashPassword(rawPassword);
    //     user.Username = login;
    //     user.Password = hashedPassword;
    //     user.DisplayName = displayName;
    //     user.Roleid = modelRoleId;
    //     user.PrefEng = prefEng;
    //     return user;
    // }
}