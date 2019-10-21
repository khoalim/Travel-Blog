using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MasteryBlog.Migrations
{
    public partial class AddedTagToPostID2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostID", "TagID" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2019, 10, 21, 5, 0, 18, 850, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2019, 10, 21, 5, 0, 18, 852, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2019, 10, 21, 5, 0, 18, 852, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2019, 10, 21, 5, 0, 18, 852, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2019, 10, 21, 5, 0, 18, 852, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2019, 10, 21, 5, 0, 18, 852, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 7,
                column: "PublishDate",
                value: new DateTime(2019, 10, 21, 5, 0, 18, 852, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 8,
                column: "PublishDate",
                value: new DateTime(2019, 10, 21, 5, 0, 18, 852, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostID", "TagID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2019, 10, 21, 2, 24, 20, 137, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2019, 10, 21, 2, 24, 20, 139, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2019, 10, 21, 2, 24, 20, 139, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2019, 10, 21, 2, 24, 20, 139, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2019, 10, 21, 2, 24, 20, 139, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2019, 10, 21, 2, 24, 20, 139, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 7,
                column: "PublishDate",
                value: new DateTime(2019, 10, 21, 2, 24, 20, 139, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 8,
                column: "PublishDate",
                value: new DateTime(2019, 10, 21, 2, 24, 20, 139, DateTimeKind.Local));
        }
    }
}
