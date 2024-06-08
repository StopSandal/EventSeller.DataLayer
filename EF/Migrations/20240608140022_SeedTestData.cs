using DataLayer.Model.EF;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Linq;

namespace EventSeller.Migrations
{
    public partial class SeedTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Tickets WHERE ID <= 300");
            migrationBuilder.Sql("DELETE FROM Seats WHERE ID <= 60");
            migrationBuilder.Sql("DELETE FROM Events WHERE ID <= 5"); 
            migrationBuilder.Sql("DELETE FROM HallSectors WHERE ID <= 6"); 
            migrationBuilder.Sql("DELETE FROM PlaceHalls WHERE ID <= 3"); 
            migrationBuilder.Sql("DELETE FROM PlaceAddresses WHERE ID <= 2"); 

            int startPlaceAddressId = 1;
                int startPlaceHallId =  1;
                int startHallSectorId = 1;
                int startSeatId = 1;
                int startEventId = 1;
                int startTicketId = 1;

                migrationBuilder.InsertData(
                    table: "PlaceAddresses",
                    columns: new[] { "ID", "PlaceName", "Address" },
                    values: new object[,]
                    {
                        { startPlaceAddressId, "Stadium 1", "Address 1" },
                        { startPlaceAddressId + 1, "Stadium 2", "Address 2" }
                    });

                // Seed halls for Stadium 1
                migrationBuilder.InsertData(
                    table: "PlaceHalls",
                    columns: new[] { "ID", "HallName", "PlaceAddressID" },
                    values: new object[,]
                    {
                        { startPlaceHallId, "Hall 1", startPlaceAddressId },
                    });

                // Seed halls for Stadium 2
                migrationBuilder.InsertData(
                    table: "PlaceHalls",
                    columns: new[] { "ID", "HallName", "PlaceAddressID" },
                    values: new object[,]
                    {
                        { startPlaceHallId + 1, "Hall 1", startPlaceAddressId + 1 },
                        { startPlaceHallId + 2, "Hall 2", startPlaceAddressId + 1 }
                    });

                // Seed hall sectors
                migrationBuilder.InsertData(
                    table: "HallSectors",
                    columns: new[] { "ID", "SectorName", "PlaceHallID" },
                    values: new object[,]
                    {
                        { startHallSectorId, "Sector 1", startPlaceHallId },
                        { startHallSectorId + 1, "Sector 2", startPlaceHallId },
                        { startHallSectorId + 2, "Sector 1", startPlaceHallId + 1 },
                        { startHallSectorId + 3, "Sector 2", startPlaceHallId + 1 },
                        { startHallSectorId + 4, "Sector 1", startPlaceHallId + 2 },
                        { startHallSectorId + 5, "Sector 2", startPlaceHallId + 2 }
                    });

            int totalSectors = 6;
            int seatsPerSector = 10;

            // Generate sector IDs
            List<int> sectorIds = Enumerable.Range(startHallSectorId, totalSectors).ToList();

            // Create a list to hold seat data
            List<object[]> seatsList = new List<object[]>();

            // Loop through each sector
            foreach (var sectorId in sectorIds)
            {
                // Generate seats for the current sector
                for (int i = 0; i < seatsPerSector; i++)
                {
                    // Create seat data and add it to the list
                    seatsList.Add(new object[] {
                    startSeatId++, // Seat ID
                    $"Place {i + 1}", // PlaceName
                    $"Type {sectorId}", // PlaceType
                    sectorId // HallSectorID
                });
                }
            }
            object[,] seats = new object[seatsList.Count, seatsList[0].Length];
            for (int i = 0; i < seatsList.Count; i++)
            {
                for (int j = 0; j < seatsList[i].Length; j++)
                {
                    seats[i, j] = seatsList[i][j];
                }
            }
            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "ID", "PlaceName", "PlaceType", "HallSectorID" },
                values: seats
            );

            var events = new object[,]
                {
                    // Define events with start and end dates
                    { startEventId, "Event 1", "Description 1", new DateTime(2023, 6, 1), new DateTime(2023, 6, 2) },
                    { startEventId + 1, "Event 2", "Description 2", new DateTime(2024, 6, 3), new DateTime(2024, 6, 4) },
                    { startEventId + 2, "Event 3", "Description 3", new DateTime(2024, 6, 5), new DateTime(2024, 6, 6) },
                    { startEventId + 3, "Event 4", "Description 4", new DateTime(2025, 6, 7), new DateTime(2025, 6, 8) },
                    { startEventId + 4, "Event 5", "Description 5", new DateTime(2025, 6, 9), new DateTime(2025, 6, 10) }
                };

                migrationBuilder.InsertData(
                    table: "Events",
                    columns: new[] { "ID", "Name", "Description", "StartEventDateTime", "EndEventDateTime" },
                    values: events);

                int totalEvents = events.GetLength(0);
            List<object[]> ticketsList = new List<object[]>();

            // Loop through each event
            for (int eventId = 0; eventId < totalEvents; eventId++)
            {
                // Get the start and end date time for the current event
                DateTime eventStartDate = (DateTime)events[eventId, 3];
                DateTime eventEndDate = (DateTime)events[eventId, 4];

                foreach (var sectorId in sectorIds)
                {
                    for (int seatId = 0; seatId < seatsPerSector; seatId++)
                    {
                        decimal ticketPrice = 10.00m;

                        // Calculate ticket start and end date time based on event dates
                        DateTime ticketStartDateTime = eventStartDate;
                        DateTime ticketEndDateTime = eventEndDate;

                        // Create ticket data
                        ticketsList.Add(new object[] {
                        startTicketId++, null, null, ticketPrice, false,
                        ticketStartDateTime, ticketEndDateTime,
                        (sectorId - startHallSectorId) * seatsPerSector + seatId + 1,
                        eventId + startEventId
                    });
                    }
                }
            }

            // Convert the list of tickets to a two-dimensional array
            object[,] tickets = new object[ticketsList.Count, ticketsList[0].Length];
            for (int i = 0; i < ticketsList.Count; i++)
            {
                for (int j = 0; j < ticketsList[i].Length; j++)
                {
                    tickets[i, j] = ticketsList[i][j];
                }
            }
            migrationBuilder.InsertData(
                            table: "Tickets",
                            columns: new[] { "ID", "Name", "Description", "Price", "isSold", "TicketStartDateTime", "TicketEndDateTime", "SeatID", "EventID" },
                            values: tickets

                        );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Tickets WHERE ID < 300");
            migrationBuilder.Sql("DELETE FROM Seats WHERE ID < 60");
            migrationBuilder.Sql("DELETE FROM Events WHERE ID < 5");
            migrationBuilder.Sql("DELETE FROM HallSectors WHERE ID < 6");
            migrationBuilder.Sql("DELETE FROM PlaceHalls WHERE ID < 3");
            migrationBuilder.Sql("DELETE FROM PlaceAddresses WHERE ID < 2");
        }
    }
}
