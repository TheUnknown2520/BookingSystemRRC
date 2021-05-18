using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingSystemRRC.Migrations
{
    public partial class BookingSystemRRC2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GuestNumber",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_GuestNumber",
                table: "Bookings",
                column: "GuestNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Guests_GuestNumber",
                table: "Bookings",
                column: "GuestNumber",
                principalTable: "Guests",
                principalColumn: "GuestNumber",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Guests_GuestNumber",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_GuestNumber",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "GuestNumber",
                table: "Bookings");
        }
    }
}
