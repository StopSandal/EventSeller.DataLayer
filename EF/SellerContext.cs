using Microsoft.EntityFrameworkCore;
using System;

namespace DataLayer.Model.EF
{
    public class SellerContext : DbContext
    {
        DbSet<Ticket> Tickets { get; set; }
        DbSet<Event> Events { get; set; }
        DbSet<PlaceAddress> PlaceAddresses { get; set; }
        DbSet<PlaceHall> PlaceHalls { get; set; }
        DbSet<HallSector> HallSectors { get; set; }
        DbSet<TicketSeat> Seats { get; set; }
        public SellerContext(DbContextOptions<SellerContext> options) : base(options)
        {
        }

    }
}
