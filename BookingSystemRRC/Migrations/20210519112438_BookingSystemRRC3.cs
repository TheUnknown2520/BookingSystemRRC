using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingSystemRRC.Migrations
{
    public partial class BookingSystemRRC3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeSlotBookings_Guests_GuestNumber",
                table: "TimeSlotBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeSlotBookings_TimeSlotBookings_TimeSlotbookingsTimeSlotId",
                table: "TimeSlotBookings");

            migrationBuilder.DropIndex(
                name: "IX_TimeSlotBookings_GuestNumber",
                table: "TimeSlotBookings");

            migrationBuilder.DropIndex(
                name: "IX_TimeSlotBookings_TimeSlotbookingsTimeSlotId",
                table: "TimeSlotBookings");

            migrationBuilder.DropColumn(
                name: "BookingComment",
                table: "TimeSlotBookings");

            migrationBuilder.DropColumn(
                name: "BookingNumber",
                table: "TimeSlotBookings");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TimeSlotBookings");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "TimeSlotBookings");

            migrationBuilder.DropColumn(
                name: "GuestNumber",
                table: "TimeSlotBookings");

            migrationBuilder.DropColumn(
                name: "NumberOfPeople",
                table: "TimeSlotBookings");

            migrationBuilder.DropColumn(
                name: "TimeSlotbookingsTimeSlotId",
                table: "TimeSlotBookings");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "TimeSlotBookings");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "TimeSlotBookings");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TimeSlotId",
                table: "TimeSlotBookings",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "GuestNumber",
                table: "Guests",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfPeople = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingComment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeSlotbookingsTimeSlotId = table.Column<int>(type: "int", nullable: true),
                    GuestNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingNumber);
                    table.ForeignKey(
                        name: "FK_Bookings_Guests_GuestNumber",
                        column: x => x.GuestNumber,
                        principalTable: "Guests",
                        principalColumn: "GuestNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_TimeSlotBookings_TimeSlotbookingsTimeSlotId",
                        column: x => x.TimeSlotbookingsTimeSlotId,
                        principalTable: "TimeSlotBookings",
                        principalColumn: "TimeSlotId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_GuestNumber",
                table: "Bookings",
                column: "GuestNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_TimeSlotbookingsTimeSlotId",
                table: "Bookings",
                column: "TimeSlotbookingsTimeSlotId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TimeSlotId",
                table: "TimeSlotBookings",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "BookingComment",
                table: "TimeSlotBookings",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookingNumber",
                table: "TimeSlotBookings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "TimeSlotBookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "TimeSlotBookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GuestNumber",
                table: "TimeSlotBookings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPeople",
                table: "TimeSlotBookings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TimeSlotbookingsTimeSlotId",
                table: "TimeSlotBookings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalPrice",
                table: "TimeSlotBookings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "TimeSlotBookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GuestNumber",
                table: "Guests",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_TimeSlotBookings_GuestNumber",
                table: "TimeSlotBookings",
                column: "GuestNumber");

            migrationBuilder.CreateIndex(
                name: "IX_TimeSlotBookings_TimeSlotbookingsTimeSlotId",
                table: "TimeSlotBookings",
                column: "TimeSlotbookingsTimeSlotId");

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
    }
}
