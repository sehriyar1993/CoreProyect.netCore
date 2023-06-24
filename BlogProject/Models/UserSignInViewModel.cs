using System.ComponentModel.DataAnnotations;

namespace BlogProject.Models
{
	public class UserSignInViewModel
	{
		[Required(ErrorMessage = "İstifadəçi Adını Daxil Edin")]
		public string userName { get; set; }

		[Required(ErrorMessage = "Parolunuzu Daxil Edin")]
		public string password { get; set; }
	}
}
