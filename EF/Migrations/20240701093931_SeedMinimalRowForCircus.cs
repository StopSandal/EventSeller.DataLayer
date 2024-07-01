using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventSeller.Migrations
{
    /// <inheritdoc />
    public partial class SeedMinimalRowForCircus : Migration
    {
        const string CircusEventTypeName = "Circus";
        const int MinimalRowForCircus = 2;
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql($"Update EventTypes Set MinimalSeatRowForEvent = {MinimalRowForCircus} where Name='{CircusEventTypeName}'");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"Update EventTypes Set MinimalSeatRowForEvent = null where Name='{CircusEventTypeName}'");
        }
    }
}
