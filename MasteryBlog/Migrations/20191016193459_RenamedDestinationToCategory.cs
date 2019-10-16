using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MasteryBlog.Migrations
{
    public partial class RenamedDestinationToCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Destinations_DestinationID",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.RenameColumn(
                name: "DestinationID",
                table: "Posts",
                newName: "CategoryID");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Posts",
                newName: "Genre");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_DestinationID",
                table: "Posts",
                newName: "IX_Posts_CategoryID");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "Great for family fun", "/Images/FamilyVacation.jpg", "Family Getaway" },
                    { 2, "Work hard, play hard", "/Images/BusinessTrip.jpg", "Business Trip" },
                    { 3, "Top of the buckeklist", "/Images/Retirement.jpg", "Retirement" },
                    { 4, "Paradise", "/Images/Honeymoon.jpg", "Honeymoon" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categories_CategoryID",
                table: "Posts",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categories_CategoryID",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Posts",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Posts",
                newName: "DestinationID");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_CategoryID",
                table: "Posts",
                newName: "IX_Posts_DestinationID");

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "Description", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "Great for family fun", "/Images/FamilyVacation.jpg", "Family Getaway" },
                    { 2, "Work hard, play hard", "/Images/BusinessTrip.jpg", "Business Trip" },
                    { 3, "Top of the buckeklist", "/Images/Retirement.jpg", "Retirement" },
                    { 4, "Paradise", "/Images/Honeymoon.jpg", "Honeymoon" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Destinations_DestinationID",
                table: "Posts",
                column: "DestinationID",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
