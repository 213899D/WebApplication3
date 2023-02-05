using System.ComponentModel.DataAnnotations;

namespace WebApplication3.ViewModels
{
    public class Register
    {

		[Required]
		public string FirstName { get; set; }

		[Required]
		public string LastName { get; set; }

		[Required]
		public string Gender { get; set; }

		[Required]
		public string NRIC { get; set; }

		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required, MinLength(12, ErrorMessage = "Password minimum 12 characters")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[Compare(nameof(Password), ErrorMessage = "Password and confirmation password does not match")]
		public string ConfirmPassword { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public string DateOfBirth { get; set; }

		[Required]
		public string Resume { get; set; }

		[Required]
		public string WhoamI { get; set; }
	}
}
