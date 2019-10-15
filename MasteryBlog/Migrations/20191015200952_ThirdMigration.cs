using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MasteryBlog.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DestinationID",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "/Images/Retirement.jpg");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "/Images/Honeymoon.jpg");

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "Author", "Body", "Category", "DestinationID", "PublishDate", "Tags", "Title" },
                values: new object[,]
                {
                    { 1, "Jane Doe", "Clean excursion wanderlust design wanderlust WordPress blogger, organized theme website organized excursion cute. Darn colorful colorful whimsical, WordPress whimsical colorful modern design webdesign clean adventure excursion.", "Family Getaway", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Travelling with picky eaters" },
                    { 2, "John Smith", "Theme colorful excursion webdesign, colorful travelblogger traveling darn Travel Travel design expedition. Darn whimsical traveling colorful wanderlust cute blogger.", "Family Getaway", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "10 Tips for Flying Internationally" },
                    { 3, "Mary Poppins", "Modern darn WordPress cute traveler design, webdesign WordPress Travel cute colorful whimsical modern whimsical. Expedition design adventure WordPress modern darn excursion, webdesign design darn organized.", "Business Trip", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "6 Ideas for Working Abroad" },
                    { 4, "Billie Sullivan", "Fun excursion excursion adventure traveling traveling Travel Travel, Travel website colorful pretty pretty simple. Travelblogger webdesign WordPress, adventure modern design organized website colorful theme travelblogger website simple.", "Business Trip", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "How to Survive a Working Holiday" },
                    { 5, "Jermaine Hough", "Cute website travelblogger theme WordPress whimsical organized design. Travelblogger whimsical adventure darn darn, design traveler colorful cute cute organized whimsical darn.", "Retirement", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The Only Luxury You Have - Use It Well Before It's Too Late" },
                    { 6, "Gregg Espinoza", "Darn theme whimsical cute blogger expedition blogger colorful design. Excursion pretty WordPress design expedition traveling, wanderlust excursion WordPress theme cute. Design colorful theme wanderlust travelblogger, darn webdesign simple organized webdesign.", "Retirement", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "How to travel full time on a pension" },
                    { 7, "Maxine Dickens", "Adventure excursion theme Travel clean excursion expedition. Theme WordPress pretty website wanderlust website expedition WordPress. Simple design adventure expedition colorful simple wanderlust WordPress, excursion organized website wanderlust colorful.", "Honeymoon", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "10 Best Italy Honeymoon Destinations" },
                    { 8, "Montel Dolan", "Organized design WordPress, travelblogger webdesign fun Travel cute clean clean website. Traveling travelblogger organized Travel blogger adventure traveler wanderlust webdesign, blogger Travel darn organized.", "Honeymoon", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "How To Plan A Luxury Getaway" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_DestinationID",
                table: "Posts",
                column: "DestinationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Destinations_DestinationID",
                table: "Posts",
                column: "DestinationID",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Destinations_DestinationID",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_DestinationID",
                table: "Posts");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "DestinationID",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "Images/Retirement.jpg");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "Images/Honeymoon.jpg");
        }
    }
}
