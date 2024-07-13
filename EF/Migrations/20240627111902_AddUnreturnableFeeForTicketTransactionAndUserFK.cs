using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventSeller.Migrations
{
    /// <inheritdoc />
    public partial class AddUnreturnableFeeForTicketTransactionAndUserFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TransactionPrice",
                table: "TicketTransactions",
                newName: "UnreturnableFee");

            migrationBuilder.AddColumn<decimal>(
                name: "TransactionAmount",
                table: "TicketTransactions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "TicketTransactions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_TicketTransactions_userId",
                table: "TicketTransactions",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketTransactions_AspNetUsers_userId",
                table: "TicketTransactions",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketTransactions_AspNetUsers_userId",
                table: "TicketTransactions");

            migrationBuilder.DropIndex(
                name: "IX_TicketTransactions_userId",
                table: "TicketTransactions");

            migrationBuilder.DropColumn(
                name: "TransactionAmount",
                table: "TicketTransactions");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "TicketTransactions");

            migrationBuilder.RenameColumn(
                name: "UnreturnableFee",
                table: "TicketTransactions",
                newName: "TransactionPrice");
        }
    }
}
