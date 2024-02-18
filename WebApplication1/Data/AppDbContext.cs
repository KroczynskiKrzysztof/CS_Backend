using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Models.configs;

namespace WebApplication1.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }


    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<PostTag> PostTags { get; set; }
    public DbSet<Role> Roles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserEfConfig).Assembly);


        modelBuilder.Entity<Role>().HasData(
            new Role() { Id = 1, Name = "User" },
            new Role() { Id = 2, Name = "Mod" },
            new Role() { Id = 3, Name = "Admin" }
        );
        modelBuilder.Entity<User>().HasData(
            new User { UserId = 1, DisplayName = "John Doe", Username = "john.doe", Password = "password", Roleid = 1 },
            new User
            {
                UserId = 2, DisplayName = "Jane Smith", Username = "jane.smith", Password = "password", Roleid = 1
            },
            new User
            {
                UserId = 3, DisplayName = "Bob Johnson", Username = "bob.johnson", Password = "password", Roleid = 1
            },
            new User
            {
                UserId = 4, DisplayName = "Alice Brown", Username = "alice.brown", Password = "password", Roleid = 1
            }
        );
        modelBuilder.Entity<Tag>().HasData(
            new Tag { TagId = 1, Name = "Fitness" },
            new Tag { TagId = 2, Name = "Travel" },
            new Tag { TagId = 3, Name = "Fashion" },
            new Tag { TagId = 4, Name = "Health" },
            new Tag { TagId = 5, Name = "Cooking" },
            new Tag { TagId = 6, Name = "Mindfulness" },
            new Tag { TagId = 7, Name = "DIY" },
            new Tag { TagId = 8, Name = "Finance" },
            new Tag { TagId = 9, Name = "Photography" },
            new Tag { TagId = 10, Name = "Communication" },
            new Tag { TagId = 11, Name = "Gardening" },
            new Tag { TagId = 12, Name = "Tech" },
            new Tag { TagId = 13, Name = "Study" },
            new Tag { TagId = 14, Name = "Public Speaking" },
            new Tag { TagId = 15, Name = "Minimalism" },
            new Tag { TagId = 16, Name = "Snacks" },
            new Tag { TagId = 17, Name = "Language Learning" },
            new Tag { TagId = 18, Name = "Fitness Gear" },
            new Tag { TagId = 19, Name = "Productivity" },
            new Tag { TagId = 20, Name = "Nature Photography" }
        );

        modelBuilder.Entity<Post>().HasData(
            new Post
            {
                PostId = 1, Title = "Healthy Lifestyle Tips", Content = "Here are some tips for a healthy lifestyle...",
                DateTime = DateTime.Now, UserId = 1
            },
            new Post
            {
                PostId = 2, Title = "Traveling on a Budget", Content = "Explore the world without breaking the bank...",
                DateTime = DateTime.Now, UserId = 2
            },
            new Post
            {
                PostId = 3, Title = "Quick and Easy Recipes",
                Content = "Discover delicious recipes that are both quick and easy to prepare.",
                DateTime = DateTime.Now, UserId = 3
            },
            new Post
            {
                PostId = 4, Title = "Effective Time Management",
                Content = "Master the art of time management with these practical tips and techniques.",
                DateTime = DateTime.Now, UserId = 4
            },
            new Post
            {
                PostId = 5, Title = "DIY Home Decor Ideas",
                Content = "Transform your living space with these creative and budget-friendly DIY home decor ideas.",
                DateTime = DateTime.Now, UserId = 1
            },
            new Post
            {
                PostId = 6, Title = "Mindfulness Meditation Guide",
                Content =
                    "Explore the benefits of mindfulness meditation and learn how to incorporate it into your daily routine.",
                DateTime = DateTime.Now, UserId = 2
            },
            new Post
            {
                PostId = 7, Title = "Fitness Workout for Beginners",
                Content =
                    "Start your fitness journey with a beginner-friendly workout routine that you can do at home.",
                DateTime = DateTime.Now, UserId = 3
            },
            new Post
            {
                PostId = 8, Title = "Financial Planning 101",
                Content =
                    "Learn the basics of financial planning to secure your future and achieve your financial goals.",
                DateTime = DateTime.Now, UserId = 4
            },
            new Post
            {
                PostId = 9, Title = "Photography Tips for Amateurs",
                Content =
                    "Capture stunning photos with these essential photography tips designed for amateur photographers.",
                DateTime = DateTime.Now, UserId = 1
            },
            new Post
            {
                PostId = 10, Title = "Effective Communication Skills",
                Content =
                    "Enhance your communication skills with practical strategies to express yourself more clearly and confidently.",
                DateTime = DateTime.Now, UserId = 2
            },
            new Post
            {
                PostId = 11, Title = "Gardening for Beginners",
                Content =
                    "Start your own garden with these simple and helpful tips for beginners passionate about gardening.",
                DateTime = DateTime.Now, UserId = 3
            },
            new Post
            {
                PostId = 12, Title = "Tech Gadgets Worth Exploring",
                Content =
                    "Stay up-to-date with the latest tech gadgets that are both innovative and worth exploring in 2024.",
                DateTime = DateTime.Now, UserId = 4
            },
            new Post
            {
                PostId = 13, Title = "Effective Study Habits",
                Content =
                    "Boost your academic performance with these effective study habits that promote learning and retention.",
                DateTime = DateTime.Now, UserId = 1
            },
            new Post
            {
                PostId = 14, Title = "Art of Public Speaking",
                Content = "Unleash your inner orator with tips and techniques to master the art of public speaking.",
                DateTime = DateTime.Now, UserId = 2
            },
            new Post
            {
                PostId = 15, Title = "Minimalist Living Lifestyle",
                Content =
                    "Embrace a minimalist lifestyle with practical tips on decluttering and simplifying your life.",
                DateTime = DateTime.Now, UserId = 3
            },
            new Post
            {
                PostId = 16, Title = "Healthy Snack Ideas",
                Content =
                    "Satisfy your cravings with nutritious and delicious healthy snack ideas for any time of the day.",
                DateTime = DateTime.Now, UserId = 4
            },
            new Post
            {
                PostId = 17, Title = "Learning a New Language",
                Content =
                    "Embark on a language-learning journey with effective strategies and resources for beginners.",
                DateTime = DateTime.Now, UserId = 1
            },
            new Post
            {
                PostId = 18, Title = "Budget-Friendly Fitness Gear",
                Content = "Discover affordable fitness gear that will enhance your workouts without breaking the bank.",
                DateTime = DateTime.Now, UserId = 2
            },
            new Post
            {
                PostId = 19, Title = "Productivity Apps for Professionals",
                Content = "Boost your productivity with these must-have apps designed for busy professionals.",
                DateTime = DateTime.Now, UserId = 3
            },
            new Post
            {
                PostId = 20, Title = "Nature Photography Essentials",
                Content =
                    "Capture the beauty of nature with essential tips and techniques for stunning nature photography.",
                DateTime = DateTime.Now, UserId = 4
            }
        );

        modelBuilder.Entity<PostTag>().HasData(
            new PostTag { PostID = 1, TagID = 1 },
            new PostTag { PostID = 1, TagID = 4 },
            new PostTag { PostID = 2, TagID = 2 },
            new PostTag { PostID = 2, TagID = 3 },
            new PostTag { PostID = 3, TagID = 5 },
            new PostTag { PostID = 3, TagID = 4 },
            new PostTag { PostID = 4, TagID = 8 },
            new PostTag { PostID = 4, TagID = 6 },
            new PostTag { PostID = 5, TagID = 7 },
            new PostTag { PostID = 5, TagID = 3 },
            new PostTag { PostID = 6, TagID = 1 },
            new PostTag { PostID = 6, TagID = 2 },
            new PostTag { PostID = 7, TagID = 18 },
            new PostTag { PostID = 7, TagID = 16 },
            new PostTag { PostID = 8, TagID = 14 },
            new PostTag { PostID = 8, TagID = 10 },
            new PostTag { PostID = 9, TagID = 11 },
            new PostTag { PostID = 9, TagID = 7 },
            new PostTag { PostID = 10, TagID = 12 },
            new PostTag { PostID = 10, TagID = 2 },
            new PostTag { PostID = 11, TagID = 13 },
            new PostTag { PostID = 11, TagID = 11 },
            new PostTag { PostID = 12, TagID = 3 },
            new PostTag { PostID = 12, TagID = 12 },
            new PostTag { PostID = 13, TagID = 9 },
            new PostTag { PostID = 13, TagID = 13 },
            new PostTag { PostID = 14, TagID = 10 },
            new PostTag { PostID = 14, TagID = 14 },
            new PostTag { PostID = 15, TagID = 15 },
            new PostTag { PostID = 15, TagID = 3 },
            new PostTag { PostID = 16, TagID = 16 },
            new PostTag { PostID = 16, TagID = 4 },
            new PostTag { PostID = 17, TagID = 17 },
            new PostTag { PostID = 17, TagID = 7 },
            new PostTag { PostID = 18, TagID = 18 },
            new PostTag { PostID = 18, TagID = 8 },
            new PostTag { PostID = 19, TagID = 19 },
            new PostTag { PostID = 19, TagID = 4 },
            new PostTag { PostID = 20, TagID = 20 },
            new PostTag { PostID = 20, TagID = 9 }
        );

        modelBuilder.Entity<Comment>().HasData(
            new Comment { PostId = 1, CommentId = 1, UserId = 1, Content = "Great post!", DateTime = DateTime.Now },
            new Comment
            {
                PostId = 1, CommentId = 2, UserId = 2, Content = "Thanks for the tips!", DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 2, CommentId = 3, UserId = 3, Content = "I love budget travel!", DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 2, CommentId = 4, UserId = 4, Content = "Awesome information.", DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 3, CommentId = 5, UserId = 1,
                Content = "These recipes look delicious! Can't wait to try them.", DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 3, CommentId = 6, UserId = 2,
                Content = "I'm a fan of quick and easy recipes. Thanks for sharing!", DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 4, CommentId = 7, UserId = 3,
                Content = "Time management is crucial. I'll definitely apply these tips.", DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 4, CommentId = 8, UserId = 4,
                Content = "I struggle with time management. Your tips are helpful!", DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 5, CommentId = 9, UserId = 1,
                Content = "I never thought of DIY home decor. Excited to give it a try!", DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 5, CommentId = 10, UserId = 2,
                Content = "DIY home decor is a great way to personalize your space.", DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 6, CommentId = 11, UserId = 3,
                Content = "Mindfulness has changed my life. Can't wait to read more.", DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 6, CommentId = 12, UserId = 4,
                Content = "Mindfulness meditation has so many benefits. Thanks for sharing.", DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 7, CommentId = 13, UserId = 1,
                Content = "Home workouts are my go-to. Any specific exercises you recommend?", DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 7, CommentId = 14, UserId = 2,
                Content = "Budget-friendly fitness is the way to go! Great post.", DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 8, CommentId = 15, UserId = 3,
                Content = "Financial planning is something everyone should focus on. Thanks for the advice.",
                DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 8, CommentId = 16, UserId = 4,
                Content = "These financial planning tips are practical and helpful.", DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 9, CommentId = 17, UserId = 1,
                Content = "I've always wanted to try photography. Any camera recommendations?", DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 9, CommentId = 18, UserId = 2,
                Content = "Photography is a great hobby. Start with your smartphone camera!", DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 10, CommentId = 19, UserId = 3,
                Content = "Communication skills are essential. Can you recommend any books?", DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 10, CommentId = 20, UserId = 4,
                Content = "I'm working on my communication skills. These tips are valuable.", DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 11, CommentId = 21, UserId = 1,
                Content = "Gardening is a therapeutic hobby. Any plant suggestions for beginners?",
                DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 11, CommentId = 22, UserId = 2,
                Content = "I started gardening recently. Tomatoes and herbs are great for beginners!",
                DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 12, CommentId = 23, UserId = 3,
                Content = "Excited to explore the latest tech gadgets. Any personal recommendations?",
                DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 12, CommentId = 24, UserId = 4,
                Content = "Tech gadgets are always evolving. Stay updated and enjoy exploring!", DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 13, CommentId = 25, UserId = 1,
                Content = "Effective study habits are a game-changer. How do you handle distractions?",
                DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 13, CommentId = 26, UserId = 2,
                Content = "Creating a dedicated study space helps minimize distractions. Give it a try!",
                DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 14, CommentId = 27, UserId = 3,
                Content = "Public speaking terrifies me. Any tips for overcoming stage fright?", DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 14, CommentId = 28, UserId = 4,
                Content = "Practice is key! Start small, and gradually build your confidence on stage.",
                DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 15, CommentId = 29, UserId = 1,
                Content = "Minimalist living has changed my perspective. How did you start your journey?",
                DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 15, CommentId = 30, UserId = 2,
                Content = "I began by decluttering one room at a time. It's a gradual process, but so rewarding.",
                DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 16, CommentId = 31, UserId = 3,
                Content = "Healthy snacks are a lifesaver! Any favorite recipes you'd like to share?",
                DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 16, CommentId = 32, UserId = 4,
                Content = "Try mixing Greek yogurt with fruits for a delicious and healthy snack!",
                DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 17, CommentId = 33, UserId = 1,
                Content = "Learning a new language sounds fascinating. How do you stay motivated?",
                DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 17, CommentId = 34, UserId = 2,
                Content = "I set small goals and celebrate achievements. It keeps me motivated to learn more.",
                DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 18, CommentId = 35, UserId = 3,
                Content = "Budget-friendly fitness gear is a must. Any specific brands you recommend?",
                DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 18, CommentId = 36, UserId = 4,
                Content = "Look for sales and discounts. Many reputable brands offer affordable options.",
                DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 19, CommentId = 37, UserId = 1,
                Content = "Productivity apps make a huge difference. Which ones are your favorites?",
                DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 19, CommentId = 38, UserId = 2,
                Content = "I swear by task management apps. They keep me organized and focused.",
                DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 20, CommentId = 39, UserId = 3,
                Content = "Nature photography is breathtaking. Any favorite locations for capturing nature shots?",
                DateTime = DateTime.Now
            },
            new Comment
            {
                PostId = 20, CommentId = 40, UserId = 4,
                Content = "Visit parks, nature reserves, and scenic landscapes for stunning photography opportunities.",
                DateTime = DateTime.Now
            }
        );
    }
}