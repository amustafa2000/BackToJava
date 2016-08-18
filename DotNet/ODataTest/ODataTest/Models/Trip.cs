using System;
using System.ComponentModel.DataAnnotations;

namespace ODataTest.Models
{
	public class Trip
	{
		[Key]
		public String ID { get; set; }
		[Required]
		public String Name { get; set; }
	}
}