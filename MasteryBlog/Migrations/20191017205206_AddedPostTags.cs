using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MasteryBlog.Migrations
{
    public partial class AddedPostTags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Posts");

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagID);
                });

            migrationBuilder.CreateTable(
                name: "PostTags",
                columns: table => new
                {
                    PostID = table.Column<int>(nullable: false),
                    TagID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTags", x => new { x.PostID, x.TagID });
                    table.ForeignKey(
                        name: "FK_PostTags_Posts_PostID",
                        column: x => x.PostID,
                        principalTable: "Posts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTags_Tags_TagID",
                        column: x => x.TagID,
                        principalTable: "Tags",
                        principalColumn: "TagID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "Name" },
                values: new object[,]
                {
                    { 1, "Adventure" },
                    { 2, "Beach" },
                    { 3, "Explore" },
                    { 4, "Tour Guide" },
                    { 5, "Child Friendly" },
                    { 6, "Newlyweds" }
                });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostID", "TagID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 7, 1 },
                    { 5, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 5, 4 },
                    { 1, 5 },
                    { 7, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_TagID",
                table: "PostTags",
                column: "TagID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostTags");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Posts",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2019, 10, 16, 17, 6, 47, 605, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2019, 10, 16, 17, 6, 47, 607, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2019, 10, 16, 17, 6, 47, 607, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2019, 10, 16, 17, 6, 47, 607, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2019, 10, 16, 17, 6, 47, 607, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2019, 10, 16, 17, 6, 47, 607, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 7,
                column: "PublishDate",
                value: new DateTime(2019, 10, 16, 17, 6, 47, 607, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 8,
                column: "PublishDate",
                value: new DateTime(2019, 10, 16, 17, 6, 47, 607, DateTimeKind.Local));
        }
    }
}
