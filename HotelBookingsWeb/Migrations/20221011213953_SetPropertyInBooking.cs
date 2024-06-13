using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBookingsWeb.Migrations
{
    public partial class SetPropertyInBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PropertyId",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_PropertyId",
                table: "Bookings",
                column: "PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Properties_PropertyId",
                table: "Bookings",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Properties_PropertyId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_PropertyId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "PropertyId",
                table: "Bookings");
        }
    }
}
