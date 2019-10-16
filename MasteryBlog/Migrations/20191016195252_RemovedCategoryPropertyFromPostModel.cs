using Microsoft.EntityFrameworkCore.Migrations;

namespace MasteryBlog.Migrations
{
    public partial class RemovedCategoryPropertyFromPostModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Top of the bucketlist");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Posts",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Top of the buckeklist");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 1,
                column: "Genre",
                value: "Family Getaway");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 2,
                column: "Genre",
                value: "Family Getaway");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 3,
                column: "Genre",
                value: "Business Trip");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 4,
                column: "Genre",
                value: "Business Trip");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 5,
                column: "Genre",
                value: "Retirement");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 6,
                column: "Genre",
                value: "Retirement");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 7,
                column: "Genre",
                value: "Honeymoon");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 8,
                column: "Genre",
                value: "Honeymoon");
        }
    }
}
