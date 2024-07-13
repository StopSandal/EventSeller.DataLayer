using EventSeller.DataLayer.Entities;
using EventSeller.DataLayer.Enums;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Collections.Generic;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

#nullable disable

namespace EventSeller.Migrations
{
    /// <inheritdoc />
    public partial class SeedSoldTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var newUserId = "8be4102c-8c58-4079-b456-337ab9554d3c";
            migrationBuilder.Sql($"UPDATE AspNetUsers SET Id = '{newUserId}' WHERE username = 'admin'");

            migrationBuilder.Sql(@" UPDATE Tickets
                    SET isSold = 1
                    WHERE (ID - 1) % 60 < 30 and ID<300;
                    ");

            migrationBuilder.Sql($"Delete TicketTransactions WHERE ID <= 150"); // if already exists

            List<object[]> transactionsList = new List<object[]>();
            long startTransactionId = 1;

            for (int eventId = 0; eventId < 5; eventId++)
            {
                var startTicket = eventId * 60;
                for (int i = 1; i <= 30; i++)
                {
                    transactionsList.Add(new object[]
                    {
                    startTransactionId, //ID
                    newUserId, // UserId
                    startTicket + i, // TicketID
                    10.00m, // TransactionAmount
                    1.00m, // UnreturnableFee
                    "USD", // CurrencyType
                    DateTime.UtcNow, // Date
                    startTransactionId++, // TransactionId
                    false // IsReturned
                    });
                }
            }

            object[,] transaction = new object[transactionsList.Count, transactionsList[0].Length];
            for (int i = 0; i < transactionsList.Count; i++)
            {
                for (int j = 0; j < transactionsList[i].Length; j++)
                {
                    transaction[i, j] = transactionsList[i][j];
                }
            }

            migrationBuilder.InsertData(
                table: "TicketTransactions",
                columns: new[] { "ID" ,"userId", "TicketID", "TransactionAmount", "UnreturnableFee", "CurrencyType", "Date", "TransactionId", "IsReturned" },
                values: transaction
            );

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var newId = Guid.NewGuid().ToString();
            migrationBuilder.Sql($"UPDATE AspNetUsers SET Id = '{newId}' WHERE username = 'admin'");

            migrationBuilder.Sql(@" UPDATE Tickets
                    SET isSold = 0
                    WHERE (ID - 1) % 60 < 30 and ID<300;
                    ");

            migrationBuilder.Sql($"Delete TicketTransactions WHERE ID <= 150");
        }
    }
}
