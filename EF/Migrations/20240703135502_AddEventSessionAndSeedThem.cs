using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventSeller.Migrations
{
    /// <inheritdoc />
    public partial class AddEventSessionAndSeedThem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Events_EventID",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_PlaceHalls_HallID",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_HallID",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "HallID",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TicketEndDateTime",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TicketStartDateTime",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "EventID",
                table: "Tickets",
                newName: "EventSessionID");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_EventID",
                table: "Tickets",
                newName: "IX_Tickets_EventSessionID");

            migrationBuilder.CreateTable(
                name: "EventSessions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartSessionDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndSessionDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventID = table.Column<long>(type: "bigint", nullable: false),
                    HallID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventSessions_Events_EventID",
                        column: x => x.EventID,
                        principalTable: "Events",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventSessions_PlaceHalls_HallID",
                        column: x => x.HallID,
                        principalTable: "PlaceHalls",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventSessions_EventID",
                table: "EventSessions",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_EventSessions_HallID",
                table: "EventSessions",
                column: "HallID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_EventSessions_EventSessionID",
                table: "Tickets",
                column: "EventSessionID",
                principalTable: "EventSessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_EventSessions_EventSessionID",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "EventSessions");

            migrationBuilder.RenameColumn(
                name: "EventSessionID",
                table: "Tickets",
                newName: "EventID");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_EventSessionID",
                table: "Tickets",
                newName: "IX_Tickets_EventID");

            migrationBuilder.AddColumn<long>(
                name: "HallID",
                table: "Tickets",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TicketEndDateTime",
                table: "Tickets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TicketStartDateTime",
                table: "Tickets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_HallID",
                table: "Tickets",
                column: "HallID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Events_EventID",
                table: "Tickets",
                column: "EventID",
                principalTable: "Events",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_PlaceHalls_HallID",
                table: "Tickets",
                column: "HallID",
                principalTable: "PlaceHalls",
                principalColumn: "ID");
        }
    }
}
