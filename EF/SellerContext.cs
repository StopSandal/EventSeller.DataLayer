﻿using EventSeller.DataLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataLayer.Model.EF
{
    public class SellerContext : IdentityDbContext<User>
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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
