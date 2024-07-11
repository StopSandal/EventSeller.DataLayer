using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventSeller.Migrations
{
    /// <inheritdoc />
    public partial class SeedEventTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            int startEventTypeId = 1;
            var events = new object[,] {

                    { startEventTypeId, "Cinema",  60, 10 },
                    { startEventTypeId + 1, "Theater", 240, 15 },
                    { startEventTypeId + 2, "Circus", 15, 10 },
                    { startEventTypeId + 3, "StandUp", 120, 10 },
                    { startEventTypeId + 4, "Concert", 360, 20 }
    };

            migrationBuilder.InsertData(
                table: "EventTypes",
                columns: new[] { "Id", "Name", "MinutesForMoneyReturn", "BookingFeePercentage" },
                values: events);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM EventTypes WHERE ID <= 5");
        }
    }
}
