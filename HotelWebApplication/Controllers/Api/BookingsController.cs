using System;
using HotelWebApplication.Data;
using HotelWebApplication.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelWebApplication.Controllers.Api
{
    [ApiController]
    [Route("api/bookings")]
    public class BookingsController : ControllerBase
    {
        private readonly HotelContext _context;

        public BookingsController(HotelContext context) => _context = context;

        [HttpGet]
        public IEnumerable<Booking> Get()
        {
            return _context.Bookings.ToList();
        }
    }
}

