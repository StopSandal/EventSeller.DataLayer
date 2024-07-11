using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventSeller.Migrations
{
    /// <inheritdoc />
    public partial class AddTicketBookingAndEventTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Seats_SeatID",
                table: "Tickets");

            migrationBuilder.AlterColumn<long>(
                name: "SeatID",
                table: "Tickets",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<DateTime>(
                name: "BookedUntil",
                table: "Tickets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "HallID",
                table: "Tickets",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartEventDateTime",
                table: "Events",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndEventDateTime",
                table: "Events",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "EventTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinutesForMoneyReturn = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_HallID",
                table: "Tickets",
                column: "HallID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_PlaceHalls_HallID",
                table: "Tickets",
                column: "HallID",
                principalTable: "PlaceHalls",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Seats_SeatID",
                table: "Tickets",
                column: "SeatID",
                principalTable: "Seats",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_PlaceHalls_HallID",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Seats_SeatID",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "EventTypes");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_HallID",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "BookedUntil",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "HallID",
                table: "Tickets");

            migrationBuilder.AlterColumn<long>(
                name: "SeatID",
                table: "Tickets",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartEventDateTime",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndEventDateTime",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Seats_SeatID",
                table: "Tickets",
                column: "SeatID",
                principalTable: "Seats",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
