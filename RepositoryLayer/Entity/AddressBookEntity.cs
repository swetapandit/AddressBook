using System;
using System.ComponentModel.DataAnnotations;

namespace ModelLayer.Entity
{
	public class AddressBookEntity
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		public string Email { get; set; }

		[Required]
		public string PhoneNumber { get; set; }
	}
}