using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MasteryBlog.Migrations
{
    public partial class PostByTagsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TagID",
                table: "Posts",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Posts_TagID",
                table: "Posts",
                column: "TagID");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Tags_TagID",
                table: "Posts",
                column: "TagID",
                principalTable: "Tags",
                principalColumn: "TagID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Tags_TagID",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_TagID",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "TagID",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2019, 10, 17, 16, 52, 6, 379, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2019, 10, 17, 16, 52, 6, 380, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2019, 10, 17, 16, 52, 6, 380, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2019, 10, 17, 16, 52, 6, 380, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2019, 10, 17, 16, 52, 6, 380, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2019, 10, 17, 16, 52, 6, 380, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 7,
                column: "PublishDate",
                value: new DateTime(2019, 10, 17, 16, 52, 6, 380, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 8,
                column: "PublishDate",
                value: new DateTime(2019, 10, 17, 16, 52, 6, 380, DateTimeKind.Local));
        }
    }
}
