using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventSeller.Migrations
{
    /// <inheritdoc />
    public partial class SeedSoldTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // predeterminate User ID
            var newUserId = "8be4102c-8c58-4079-b456-337ab9554d3c";

            migrationBuilder.Sql("ALTER TABLE AspNetUserRoles NOCHECK CONSTRAINT ALL");
            migrationBuilder.Sql("ALTER TABLE AspNetUserClaims NOCHECK CONSTRAINT ALL");
            migrationBuilder.Sql("ALTER TABLE AspNetUserLogins NOCHECK CONSTRAINT ALL");
            migrationBuilder.Sql("ALTER TABLE AspNetUserTokens NOCHECK CONSTRAINT ALL");

            migrationBuilder.Sql($@"
            IF EXISTS (SELECT 1 FROM AspNetUsers WHERE UserName = 'admin' AND Id != '{newUserId}')
            BEGIN
                UPDATE AspNetUserRoles SET UserId = '{newUserId}' WHERE UserId = (SELECT Id FROM AspNetUsers WHERE UserName = 'admin')
                UPDATE AspNetUserClaims SET UserId = '{newUserId}' WHERE UserId = (SELECT Id FROM AspNetUsers WHERE UserName = 'admin')
                UPDATE AspNetUserLogins SET UserId = '{newUserId}' WHERE UserId = (SELECT Id FROM AspNetUsers WHERE UserName = 'admin')
                UPDATE AspNetUserTokens SET UserId = '{newUserId}' WHERE UserId = (SELECT Id FROM AspNetUsers WHERE UserName = 'admin')
                UPDATE AspNetUsers SET Id = '{newUserId}' WHERE UserName = 'admin'
            END
        ");

            migrationBuilder.Sql("ALTER TABLE AspNetUserRoles CHECK CONSTRAINT ALL");
            migrationBuilder.Sql("ALTER TABLE AspNetUserClaims CHECK CONSTRAINT ALL");
            migrationBuilder.Sql("ALTER TABLE AspNetUserLogins CHECK CONSTRAINT ALL");
            migrationBuilder.Sql("ALTER TABLE AspNetUserTokens CHECK CONSTRAINT ALL");

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
                columns: new[] { "ID", "userId", "TicketID", "TransactionAmount", "UnreturnableFee", "CurrencyType", "Date", "TransactionId", "IsReturned" },
                values: transaction
            );

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" UPDATE Tickets
                    SET isSold = 0
                    WHERE (ID - 1) % 60 < 30 and ID<300;
                    ");

            migrationBuilder.Sql($"Delete TicketTransactions WHERE ID <= 150");
        }
    }
}
