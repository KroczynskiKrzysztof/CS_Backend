using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("role_pk", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Tag_PK", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DisplayName = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    Username = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    Roleid = table.Column<int>(type: "INTEGER", nullable: false),
                    PrefEng = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("User_PK", x => x.UserId);
                    table.ForeignKey(
                        name: "user_role",
                        column: x => x.Roleid,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 32, nullable: false),
                    Content = table.Column<string>(type: "TEXT", maxLength: 512, nullable: false),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "DATE('now')"),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Post_PK", x => x.PostId);
                    table.ForeignKey(
                        name: "User_Post",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PostId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    Content = table.Column<string>(type: "TEXT", maxLength: 512, nullable: false),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Comment_PK", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "User_Comment",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTags",
                columns: table => new
                {
                    PostID = table.Column<int>(type: "INTEGER", nullable: false),
                    TagID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PostTag_PK", x => new { x.PostID, x.TagID });
                    table.ForeignKey(
                        name: "PostTag_Post",
                        column: x => x.PostID,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "PostTag_Tag",
                        column: x => x.TagID,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "User" },
                    { 2, "Mod" },
                    { 3, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { 1, "Fitness" },
                    { 2, "Travel" },
                    { 3, "Fashion" },
                    { 4, "Health" },
                    { 5, "Cooking" },
                    { 6, "Mindfulness" },
                    { 7, "DIY" },
                    { 8, "Finance" },
                    { 9, "Photography" },
                    { 10, "Communication" },
                    { 11, "Gardening" },
                    { 12, "Tech" },
                    { 13, "Study" },
                    { 14, "Public Speaking" },
                    { 15, "Minimalism" },
                    { 16, "Snacks" },
                    { 17, "Language Learning" },
                    { 18, "Fitness Gear" },
                    { 19, "Productivity" },
                    { 20, "Nature Photography" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "DisplayName", "Password", "PrefEng", "Roleid", "Username" },
                values: new object[,]
                {
                    { 1, "John Doe", "password", false, 1, "john.doe" },
                    { 2, "Jane Smith", "password", false, 1, "jane.smith" },
                    { 3, "Bob Johnson", "password", false, 1, "bob.johnson" },
                    { 4, "Alice Brown", "password", false, 1, "alice.brown" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "DateTime", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "Here are some tips for a healthy lifestyle...", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1065), "Healthy Lifestyle Tips", 1 },
                    { 2, "Explore the world without breaking the bank...", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1116), "Traveling on a Budget", 2 },
                    { 3, "Discover delicious recipes that are both quick and easy to prepare.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1119), "Quick and Easy Recipes", 3 },
                    { 4, "Master the art of time management with these practical tips and techniques.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1120), "Effective Time Management", 4 },
                    { 5, "Transform your living space with these creative and budget-friendly DIY home decor ideas.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1122), "DIY Home Decor Ideas", 1 },
                    { 6, "Explore the benefits of mindfulness meditation and learn how to incorporate it into your daily routine.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1125), "Mindfulness Meditation Guide", 2 },
                    { 7, "Start your fitness journey with a beginner-friendly workout routine that you can do at home.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1127), "Fitness Workout for Beginners", 3 },
                    { 8, "Learn the basics of financial planning to secure your future and achieve your financial goals.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1128), "Financial Planning 101", 4 },
                    { 9, "Capture stunning photos with these essential photography tips designed for amateur photographers.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1130), "Photography Tips for Amateurs", 1 },
                    { 10, "Enhance your communication skills with practical strategies to express yourself more clearly and confidently.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1132), "Effective Communication Skills", 2 },
                    { 11, "Start your own garden with these simple and helpful tips for beginners passionate about gardening.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1133), "Gardening for Beginners", 3 },
                    { 12, "Stay up-to-date with the latest tech gadgets that are both innovative and worth exploring in 2024.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1135), "Tech Gadgets Worth Exploring", 4 },
                    { 13, "Boost your academic performance with these effective study habits that promote learning and retention.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1137), "Effective Study Habits", 1 },
                    { 14, "Unleash your inner orator with tips and techniques to master the art of public speaking.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1139), "Art of Public Speaking", 2 },
                    { 15, "Embrace a minimalist lifestyle with practical tips on decluttering and simplifying your life.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1140), "Minimalist Living Lifestyle", 3 },
                    { 16, "Satisfy your cravings with nutritious and delicious healthy snack ideas for any time of the day.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1142), "Healthy Snack Ideas", 4 },
                    { 17, "Embark on a language-learning journey with effective strategies and resources for beginners.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1144), "Learning a New Language", 1 },
                    { 18, "Discover affordable fitness gear that will enhance your workouts without breaking the bank.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1146), "Budget-Friendly Fitness Gear", 2 },
                    { 19, "Boost your productivity with these must-have apps designed for busy professionals.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1147), "Productivity Apps for Professionals", 3 },
                    { 20, "Capture the beauty of nature with essential tips and techniques for stunning nature photography.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1149), "Nature Photography Essentials", 4 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Content", "DateTime", "PostId", "UserId" },
                values: new object[,]
                {
                    { 1, "Great post!", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1224), 1, 1 },
                    { 2, "Thanks for the tips!", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1227), 1, 2 },
                    { 3, "I love budget travel!", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1229), 2, 3 },
                    { 4, "Awesome information.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1230), 2, 4 },
                    { 5, "These recipes look delicious! Can't wait to try them.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1232), 3, 1 },
                    { 6, "I'm a fan of quick and easy recipes. Thanks for sharing!", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1234), 3, 2 },
                    { 7, "Time management is crucial. I'll definitely apply these tips.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1236), 4, 3 },
                    { 8, "I struggle with time management. Your tips are helpful!", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1238), 4, 4 },
                    { 9, "I never thought of DIY home decor. Excited to give it a try!", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1240), 5, 1 },
                    { 10, "DIY home decor is a great way to personalize your space.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1241), 5, 2 },
                    { 11, "Mindfulness has changed my life. Can't wait to read more.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1243), 6, 3 },
                    { 12, "Mindfulness meditation has so many benefits. Thanks for sharing.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1245), 6, 4 },
                    { 13, "Home workouts are my go-to. Any specific exercises you recommend?", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1247), 7, 1 },
                    { 14, "Budget-friendly fitness is the way to go! Great post.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1248), 7, 2 },
                    { 15, "Financial planning is something everyone should focus on. Thanks for the advice.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1250), 8, 3 },
                    { 16, "These financial planning tips are practical and helpful.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1252), 8, 4 },
                    { 17, "I've always wanted to try photography. Any camera recommendations?", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1253), 9, 1 },
                    { 18, "Photography is a great hobby. Start with your smartphone camera!", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1255), 9, 2 },
                    { 19, "Communication skills are essential. Can you recommend any books?", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1257), 10, 3 },
                    { 20, "I'm working on my communication skills. These tips are valuable.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1258), 10, 4 },
                    { 21, "Gardening is a therapeutic hobby. Any plant suggestions for beginners?", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1260), 11, 1 },
                    { 22, "I started gardening recently. Tomatoes and herbs are great for beginners!", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1263), 11, 2 },
                    { 23, "Excited to explore the latest tech gadgets. Any personal recommendations?", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1264), 12, 3 },
                    { 24, "Tech gadgets are always evolving. Stay updated and enjoy exploring!", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1266), 12, 4 },
                    { 25, "Effective study habits are a game-changer. How do you handle distractions?", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1268), 13, 1 },
                    { 26, "Creating a dedicated study space helps minimize distractions. Give it a try!", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1269), 13, 2 },
                    { 27, "Public speaking terrifies me. Any tips for overcoming stage fright?", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1271), 14, 3 },
                    { 28, "Practice is key! Start small, and gradually build your confidence on stage.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1273), 14, 4 },
                    { 29, "Minimalist living has changed my perspective. How did you start your journey?", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1275), 15, 1 },
                    { 30, "I began by decluttering one room at a time. It's a gradual process, but so rewarding.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1276), 15, 2 },
                    { 31, "Healthy snacks are a lifesaver! Any favorite recipes you'd like to share?", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1278), 16, 3 },
                    { 32, "Try mixing Greek yogurt with fruits for a delicious and healthy snack!", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1279), 16, 4 },
                    { 33, "Learning a new language sounds fascinating. How do you stay motivated?", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1281), 17, 1 },
                    { 34, "I set small goals and celebrate achievements. It keeps me motivated to learn more.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1283), 17, 2 },
                    { 35, "Budget-friendly fitness gear is a must. Any specific brands you recommend?", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1285), 18, 3 },
                    { 36, "Look for sales and discounts. Many reputable brands offer affordable options.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1286), 18, 4 },
                    { 37, "Productivity apps make a huge difference. Which ones are your favorites?", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1288), 19, 1 },
                    { 38, "I swear by task management apps. They keep me organized and focused.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1290), 19, 2 },
                    { 39, "Nature photography is breathtaking. Any favorite locations for capturing nature shots?", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1291), 20, 3 },
                    { 40, "Visit parks, nature reserves, and scenic landscapes for stunning photography opportunities.", new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1293), 20, 4 }
                });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostID", "TagID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 4 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 4, 6 },
                    { 4, 8 },
                    { 5, 3 },
                    { 5, 7 },
                    { 6, 1 },
                    { 6, 2 },
                    { 7, 16 },
                    { 7, 18 },
                    { 8, 10 },
                    { 8, 14 },
                    { 9, 7 },
                    { 9, 11 },
                    { 10, 2 },
                    { 10, 12 },
                    { 11, 11 },
                    { 11, 13 },
                    { 12, 3 },
                    { 12, 12 },
                    { 13, 9 },
                    { 13, 13 },
                    { 14, 10 },
                    { 14, 14 },
                    { 15, 3 },
                    { 15, 15 },
                    { 16, 4 },
                    { 16, 16 },
                    { 17, 7 },
                    { 17, 17 },
                    { 18, 8 },
                    { 18, 18 },
                    { 19, 4 },
                    { 19, 19 },
                    { 20, 9 },
                    { 20, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_TagID",
                table: "PostTags",
                column: "TagID");

            migrationBuilder.CreateIndex(
                name: "IX_User_Roleid",
                table: "User",
                column: "Roleid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "PostTags");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
