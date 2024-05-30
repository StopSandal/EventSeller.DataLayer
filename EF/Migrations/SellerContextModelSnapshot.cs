﻿// <auto-generated />
using System;
using DataLayer.Model.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventSeller.Migrations
{
    [DbContext(typeof(SellerContext))]
    partial class SellerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataLayer.Model.Event", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndEventDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartEventDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("DataLayer.Model.HallSector", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<long>("PlaceHallID")
                        .HasColumnType("bigint");

                    b.Property<string>("SectorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("PlaceHallID");

                    b.HasIndex("SectorName", "PlaceHallID")
                        .IsUnique();

                    b.ToTable("HallSectors");
                });

            modelBuilder.Entity("DataLayer.Model.PlaceAddress", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PlaceAddresses");
                });

            modelBuilder.Entity("DataLayer.Model.PlaceHall", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<string>("HallName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("PlaceAddressID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("PlaceAddressID");

                    b.HasIndex("HallName", "PlaceAddressID")
                        .IsUnique();

                    b.ToTable("PlaceHalls");
                });

            modelBuilder.Entity("DataLayer.Model.Ticket", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("EventID")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<long>("SeatID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("TicketEndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("TicketStartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isSold")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("EventID");

                    b.HasIndex("SeatID");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("DataLayer.Model.TicketSeat", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<long>("HallSectorID")
                        .HasColumnType("bigint");

                    b.Property<string>("PlaceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlaceRow")
                        .HasColumnType("int");

                    b.Property<int?>("PlaceSeat")
                        .HasColumnType("int");

                    b.Property<string>("PlaceType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("HallSectorID");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("DataLayer.Model.HallSector", b =>
                {
                    b.HasOne("DataLayer.Model.PlaceHall", "PlaceHall")
                        .WithMany("HallSectors")
                        .HasForeignKey("PlaceHallID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlaceHall");
                });

            modelBuilder.Entity("DataLayer.Model.PlaceHall", b =>
                {
                    b.HasOne("DataLayer.Model.PlaceAddress", "PlaceAddress")
                        .WithMany("PlaceHall")
                        .HasForeignKey("PlaceAddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlaceAddress");
                });

            modelBuilder.Entity("DataLayer.Model.Ticket", b =>
                {
                    b.HasOne("DataLayer.Model.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Model.TicketSeat", "Seat")
                        .WithMany()
                        .HasForeignKey("SeatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Seat");
                });

            modelBuilder.Entity("DataLayer.Model.TicketSeat", b =>
                {
                    b.HasOne("DataLayer.Model.HallSector", "HallSector")
                        .WithMany("TicketSeats")
                        .HasForeignKey("HallSectorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HallSector");
                });

            modelBuilder.Entity("DataLayer.Model.HallSector", b =>
                {
                    b.Navigation("TicketSeats");
                });

            modelBuilder.Entity("DataLayer.Model.PlaceAddress", b =>
                {
                    b.Navigation("PlaceHall");
                });

            modelBuilder.Entity("DataLayer.Model.PlaceHall", b =>
                {
                    b.Navigation("HallSectors");
                });
#pragma warning restore 612, 618
        }
    }
}