using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventSeller.Migrations
{
    /// <inheritdoc />
    public partial class AddEventTypesForEvent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "EventTypeID",
                table: "Events",
                type: "bigint",
                nullable: false,
                defaultValue: 1L);

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventTypeID",
                table: "Events",
                column: "EventTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventTypes_EventTypeID",
                table: "Events",
                column: "EventTypeID",
                principalTable: "EventTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventTypes_EventTypeID",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_EventTypeID",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventTypeID",
                table: "Events");
        }
    }
}
