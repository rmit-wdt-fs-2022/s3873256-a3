using System;
using Microsoft.EntityFrameworkCore;
using HotelWebApplication.Models;

namespace HotelWebApplication.Data
{
	public class HotelContext : DbContext
	{

        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Staff> Staffs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>().HasKey(x => new { x.RoomID, x.BookingDate });
        }
    }
}

