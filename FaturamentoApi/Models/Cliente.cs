using System.ComponentModel.DataAnnotations;

namespace FaturamentoAPI.Models
{
	public class Customer
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(100)]
		public string Name { get; set; }

		[Required]
		[EmailAddress]
		[StringLength(100)]
		public string Email { get; set; }

		[Required]
		[StringLength(200)]
		public string Address { get; set; }
	}
}