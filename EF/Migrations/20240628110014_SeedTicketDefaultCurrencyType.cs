using EventSeller.DataLayer.Enums;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventSeller.Migrations
{
    /// <inheritdoc />
    public partial class SeedTicketDefaultCurrencyType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var defaultCurrencyType = CurrencyTypes.USD.ToString();
            migrationBuilder.AlterColumn<string>(
                name: "CurrencyType",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: defaultCurrencyType);

            migrationBuilder.Sql($"UPDATE Tickets SET CurrencyType = '{defaultCurrencyType}' WHERE CurrencyType = ''");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var defaultCurrencyType = CurrencyTypes.USD.ToString();
            migrationBuilder.AlterColumn<string>(
                name: "CurrencyType",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.Sql($"UPDATE Tickets SET CurrencyType = ''  WHERE CurrencyType = '{defaultCurrencyType}'");
        }
    }
}
