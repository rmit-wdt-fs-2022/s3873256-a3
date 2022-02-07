using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelWebApplication.Models
{
	public class Booking
	{
		[Required]
		[Key]
		[StringLength(8, MinimumLength = 8, ErrorMessage = "Room ID must be 8 characters")]
		[RegularExpression(@"\b\d{2}\.\d{2}\.\d{2}\b", ErrorMessage = "Not a valid Room ID.")]
		[ForeignKey("RoomNumber")]
		[Display(Name = "Room ID")]
		public string RoomID { get; set; }
		public virtual Room RoomNumber { get; set; }

		[Required]
		[Key]
		[Display(Name = "Booking Date")]
        public DateTime BookingDate { get; set; }

		[Required]
		[StringLength(6, MinimumLength = 6, ErrorMessage ="Staff ID must be 6 characters long")]
		[RegularExpression(@"\b\e{1}\d{5}\b", ErrorMessage = "Not a valid Staff ID.")]
		[ForeignKey("StaffNumber")]
		[Display(Name ="Staff ID")]
        public string StaffID { get; set; }
		public virtual Staff StaffNumber { get; set; }


	}
}

