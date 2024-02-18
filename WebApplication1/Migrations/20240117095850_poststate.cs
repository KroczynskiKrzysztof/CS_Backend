using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class poststate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Posts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 10,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 12,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 13,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 14,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 15,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 16,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 17,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 18,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 19,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 20,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 21,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 22,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 23,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 24,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 25,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 26,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 27,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 28,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 29,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 30,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 31,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 32,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 33,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 34,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 35,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 36,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 37,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 38,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 39,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 40,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 10,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 12,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 13,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 16,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 17,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 18,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 19,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 20,
                column: "DateTime",
                value: new DateTime(2024, 1, 17, 10, 58, 50, 72, DateTimeKind.Local).AddTicks(1150));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 10,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 12,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 13,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 14,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 15,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 16,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 17,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 18,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 19,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 20,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 21,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 22,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 23,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 24,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 25,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 26,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 27,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 28,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 29,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 30,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 31,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 32,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 33,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 34,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 35,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 36,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 37,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 38,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 39,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 40,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 10,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 12,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 13,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 16,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 17,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 18,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 19,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 20,
                column: "DateTime",
                value: new DateTime(2024, 1, 14, 19, 38, 49, 520, DateTimeKind.Local).AddTicks(1149));
        }
    }
}
