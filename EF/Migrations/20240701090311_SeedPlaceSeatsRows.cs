using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventSeller.Migrations
{
    /// <inheritdoc />
    public partial class SeedPlaceSeatsRows : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var startSectorId = 1;
            int placeIndex = 1;
            for (int sector = startSectorId; sector <= 6; sector++)
            { 
                for (int row = 1; row <= 5; row++)
                {
                    for (int seat = 1; seat <= 2; seat++)
                    {
                        migrationBuilder.Sql(
                            $"UPDATE Seats " +
                            $"SET PlaceRow = {row}, PlaceSeat = {seat} " +
                            $"WHERE HallSectorID = {sector} AND ID = {placeIndex}");
                        placeIndex++;
                    }
                }
            }
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"UPDATE Seats SET PlaceRow = NULL, PlaceSeat = NULL");
        }
    }
}
