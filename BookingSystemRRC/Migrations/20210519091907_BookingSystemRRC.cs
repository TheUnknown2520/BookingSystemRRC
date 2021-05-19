using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingSystemRRC.Migrations
{
    public partial class BookingSystemRRC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventBooking",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventBooking", x => x.RoomId);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    GuestNumber = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuestComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.GuestNumber);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "TimeSlotBooking",
                columns: table => new
                {
                    TimeSlotId = table.Column<int>(type: "int", nullable: false),
                    WeekDays = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingNumber = table.Column<int>(type: "int", nullable: true),
                    NumberOfPeople = table.Column<int>(type: "int", nullable: true),
                    TotalPrice = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookingComment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeSlotbookingsTimeSlotId = table.Column<int>(type: "int", nullable: true),
                    GuestNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSlotBooking", x => x.TimeSlotId);
                    table.ForeignKey(
                        name: "FK_TimeSlotBooking_Guests_GuestNumber",
                        column: x => x.GuestNumber,
                        principalTable: "Guests",
                        principalColumn: "GuestNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TimeSlotBooking_TimeSlotBooking_TimeSlotbookingsTimeSlotId",
                        column: x => x.TimeSlotbookingsTimeSlotId,
                        principalTable: "TimeSlotBooking",
                        principalColumn: "TimeSlotId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TimeSlotBooking_GuestNumber",
                table: "TimeSlotBooking",
                column: "GuestNumber");

            migrationBuilder.CreateIndex(
                name: "IX_TimeSlotBooking_TimeSlotbookingsTimeSlotId",
                table: "TimeSlotBooking",
                column: "TimeSlotbookingsTimeSlotId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventBooking");

            migrationBuilder.DropTable(
                name: "TimeSlotBooking");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Guests");
        }
    }
}
