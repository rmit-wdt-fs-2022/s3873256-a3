using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelWebApplication.Models
{
	public class Room
	{
		[Required]
		[Key]
		[StringLength(8, MinimumLength = 8, ErrorMessage = "Room ID must be 8 characters")]
		[RegularExpression(@"\b\d{2}\.\d{2}\.\d{2}\b", ErrorMessage = "Not a valid Room ID.")]
		public string RoomID { get; set; }

		[Required]
		[Range(2, 300, ErrorMessage = "Capacity Must be between 2 to 300")]
        public int Capacity { get; set; }

		[Required]
        public bool HasProjector { get; set; }



    }
}

