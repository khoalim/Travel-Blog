using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MasteryBlog.Migrations
{
    public partial class AddedNewTagsAndPostTags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostID", "TagID" },
                values: new object[,]
                {
                    { 2, 5 },
                    { 6, 3 },
                    { 8, 6 }
                });

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

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "Name" },
                values: new object[,]
                {
                    { 7, "Relaxation" },
                    { 8, "Exchange Rate" }
                });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostID", "TagID" },
                values: new object[,]
                {
                    { 4, 7 },
                    { 6, 7 },
                    { 8, 7 },
                    { 4, 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostID", "TagID" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostID", "TagID" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostID", "TagID" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostID", "TagID" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostID", "TagID" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostID", "TagID" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostID", "TagID" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2019, 10, 20, 23, 9, 48, 484, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2019, 10, 20, 23, 9, 48, 486, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2019, 10, 20, 23, 9, 48, 486, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2019, 10, 20, 23, 9, 48, 486, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2019, 10, 20, 23, 9, 48, 486, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2019, 10, 20, 23, 9, 48, 486, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 7,
                column: "PublishDate",
                value: new DateTime(2019, 10, 20, 23, 9, 48, 486, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 8,
                column: "PublishDate",
                value: new DateTime(2019, 10, 20, 23, 9, 48, 486, DateTimeKind.Local));
        }
    }
}
