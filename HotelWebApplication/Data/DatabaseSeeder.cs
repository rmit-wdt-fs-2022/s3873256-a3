using System;
using HotelWebApplication.Models;

namespace HotelWebApplication.Data
{
	public class DatabaseSeeder
	{
        public DatabaseSeeder()
        {
        }
        public static void Initialise(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<HotelContext>();

            Initialise(context);
        }

        public static void Initialise(HotelContext context)
        {

            if (!context.Rooms.Any())
            {

                context.AddRange(
                   
                   new Room
                   {
                       RoomID = "14.10.31",
                       Capacity = 24,
                       HasProjector = true
                   },
                   new Room
                   {
                       RoomID = "14.09.15",
                       Capacity = 13,
                       HasProjector = false
                   },
                   new Staff
                   {
                       StaffID = "e12345",
                       FirstName = "Ryan",
                       LastName = "Wright",
                       Email = "ryanw@test.com",
                       MobilePhone = "0412121212"
                   },
                   new Staff
                   {
                       StaffID = "e54321",
                       FirstName = "John",
                       LastName = "Doe",
                       Email = "jhond@test.com",
                       MobilePhone = "0412341234"
                   }
                );

                context.SaveChanges();
            }

        }
    }
}

