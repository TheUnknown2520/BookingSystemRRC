using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingSystemRRC.Migrations
{
    public partial class BookingSystemRRC2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeSlotBooking_Guests_GuestNumber",
                table: "TimeSlotBooking");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeSlotBooking_TimeSlotBooking_TimeSlotbookingsTimeSlotId",
                table: "TimeSlotBooking");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeSlotBooking",
                table: "TimeSlotBooking");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventBooking",
                table: "EventBooking");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "TimeSlotBooking",
                newName: "TimeSlotBookings");

            migrationBuilder.RenameTable(
                name: "EventBooking",
                newName: "EventBookings");

            migrationBuilder.RenameIndex(
                name: "IX_TimeSlotBooking_TimeSlotbookingsTimeSlotId",
                table: "TimeSlotBookings",
                newName: "IX_TimeSlotBookings_TimeSlotbookingsTimeSlotId");

            migrationBuilder.RenameIndex(
                name: "IX_TimeSlotBooking_GuestNumber",
                table: "TimeSlotBookings",
                newName: "IX_TimeSlotBookings_GuestNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Username");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeSlotBookings",
                table: "TimeSlotBookings",
                column: "TimeSlotId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventBookings",
                table: "EventBookings",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSlotBookings_Guests_GuestNumber",
                table: "TimeSlotBookings",
                column: "GuestNumber",
                principalTable: "Guests",
                principalColumn: "GuestNumber",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSlotBookings_TimeSlotBookings_TimeSlotbookingsTimeSlotId",
                table: "TimeSlotBookings",
                column: "TimeSlotbookingsTimeSlotId",
                principalTable: "TimeSlotBookings",
                principalColumn: "TimeSlotId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeSlotBookings_Guests_GuestNumber",
                table: "TimeSlotBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeSlotBookings_TimeSlotBookings_TimeSlotbookingsTimeSlotId",
                table: "TimeSlotBookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeSlotBookings",
                table: "TimeSlotBookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventBookings",
                table: "EventBookings");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "TimeSlotBookings",
                newName: "TimeSlotBooking");

            migrationBuilder.RenameTable(
                name: "EventBookings",
                newName: "EventBooking");

            migrationBuilder.RenameIndex(
                name: "IX_TimeSlotBookings_TimeSlotbookingsTimeSlotId",
                table: "TimeSlotBooking",
                newName: "IX_TimeSlotBooking_TimeSlotbookingsTimeSlotId");

            migrationBuilder.RenameIndex(
                name: "IX_TimeSlotBookings_GuestNumber",
                table: "TimeSlotBooking",
                newName: "IX_TimeSlotBooking_GuestNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Username");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeSlotBooking",
                table: "TimeSlotBooking",
                column: "TimeSlotId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventBooking",
                table: "EventBooking",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSlotBooking_Guests_GuestNumber",
                table: "TimeSlotBooking",
                column: "GuestNumber",
                principalTable: "Guests",
                principalColumn: "GuestNumber",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSlotBooking_TimeSlotBooking_TimeSlotbookingsTimeSlotId",
                table: "TimeSlotBooking",
                column: "TimeSlotbookingsTimeSlotId",
                principalTable: "TimeSlotBooking",
                principalColumn: "TimeSlotId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
