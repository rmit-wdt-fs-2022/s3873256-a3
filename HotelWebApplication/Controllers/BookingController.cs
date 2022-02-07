using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelWebApplication.Data;
using HotelWebApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelWebApplication.Controllers
{
    public class BookingController : Controller
    {

        private readonly HotelContext _context;

        public BookingController(HotelContext context) => _context = context;

        
        public async Task<IActionResult> BookingIndex()
        {
            var rooms = _context.Rooms.ToList();
            ViewBag.Rooms = rooms;
            var staffs = _context.Staffs.ToList();
            ViewBag.Staffs = staffs;
            return View();
        }

        public async Task<IActionResult> AddBooking(string roomID, DateTime bookingDate, string staffID)
        {
            var bookings = _context.Bookings.Where(x => x.RoomID == roomID).ToList();
            foreach (var booking in bookings)
            {
                if(booking.BookingDate == bookingDate)
                {
                    ModelState.AddModelError(nameof(bookingDate), "There is already a booking on this date.");
                }
            }

            var newbooking = new Booking
            {
                RoomID = roomID,
                BookingDate = bookingDate,
                StaffID = staffID
            };

            _context.Bookings.Add(newbooking);
            await _context.SaveChangesAsync();

            return RedirectToAction("staff", "Staff");

        }
    }
}

