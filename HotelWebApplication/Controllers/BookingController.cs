using System;
using HotelWebApplication.Data;
using HotelWebApplication.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
    }
}

