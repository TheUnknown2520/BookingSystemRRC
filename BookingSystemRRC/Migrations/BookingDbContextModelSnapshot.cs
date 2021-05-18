﻿// <auto-generated />
using System;
using BookingSystemRRC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookingSystemRRC.Migrations
{
    [DbContext(typeof(BookingDbContext))]
    partial class BookingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookingSystemRRC.Models.Booking", b =>
                {
                    b.Property<int>("BookingNumber")
                        .HasColumnType("int");

                    b.Property<string>("BookingComment")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FkTimeSlotId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfPeople")
                        .HasColumnType("int");

                    b.Property<int?>("TimeSlotbookingsTimeSlotId")
                        .HasColumnType("int");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookingNumber");

                    b.HasIndex("TimeSlotbookingsTimeSlotId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("BookingSystemRRC.Models.Guest", b =>
                {
                    b.Property<int>("GuestNumber")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuestComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("GuestNumber");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("BookingSystemRRC.Models.TimeSlotBooking", b =>
                {
                    b.Property<int>("TimeSlotId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("WeekDays")
                        .HasColumnType("int");

                    b.HasKey("TimeSlotId");

                    b.ToTable("TimeSlotBooking");
                });

            modelBuilder.Entity("BookingSystemRRC.Models.Booking", b =>
                {
                    b.HasOne("BookingSystemRRC.Models.TimeSlotBooking", "TimeSlotbookings")
                        .WithMany()
                        .HasForeignKey("TimeSlotbookingsTimeSlotId");

                    b.Navigation("TimeSlotbookings");
                });
#pragma warning restore 612, 618
        }
    }
}
