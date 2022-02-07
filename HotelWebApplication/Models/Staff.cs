using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelWebApplication.Models
{
	public class Staff
	{
		[Required]
		[Key]
		[StringLength(6, MinimumLength = 6, ErrorMessage = "Staff ID must be 6 characters long")]
		[RegularExpression(@"\b\e{1}\d{5}\b", ErrorMessage = "Not a valid Staff ID.")]
        public string StaffID { get; set; }

		[Required]
		[StringLength(30, MinimumLength = 2, ErrorMessage = "Name must be between 2 to 30 characters long.")]
		[RegularExpression(@"\b([A-Z]{1}[a-z]{0,29})", ErrorMessage = "Not a valid Name")]
        public string FirstName { get; set; }

		[Required]
		[StringLength(30, MinimumLength = 2, ErrorMessage = "Name must be between 2 to 30 characters long.")]
		[RegularExpression(@"\b([A-Z]{1}[a-z]{0,29})", ErrorMessage = "Not a valid Name")]
		public string LastName { get; set; }

		[Required]
		[StringLength(320)]
		[RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$", ErrorMessage = "Not a valid Email address")]
        public string Email { get; set; }

		[StringLength(10, MinimumLength = 0, ErrorMessage = "Mobile Number must be 10 characters long")]
		[RegularExpression(@"^(04\d{8})", ErrorMessage = "Not a valid Mobile Number")]
        public string? MobilePhone { get; set; }

    }
}

