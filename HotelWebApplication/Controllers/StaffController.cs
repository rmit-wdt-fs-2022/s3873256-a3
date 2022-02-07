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
    public class StaffController : Controller
    {
        private readonly HotelContext _context;

        public StaffController(HotelContext context) => _context = context;

        public async Task<IActionResult> Staff()
        {
            var staff = _context.Staffs.ToList();
            return View(staff);
        }

        public async Task<IActionResult> AddStaff()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddStaff(string staffID, string firstname, string lastname, string email, string? mobilephone)
        {
            var staff = new Staff
            {
                StaffID = staffID,
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                MobilePhone = mobilephone
            };

            _context.Staffs.Add(staff);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Staff));
        }
    }
}

