using System.ComponentModel.DataAnnotations;

namespace CozaStore.WebUI.Dtos.AdminDtos
{
	public class LoginUserDto
	{
		[Required(ErrorMessage = "Kullanıcı Adınızı Giriniz")]
		public string Username { get; set; }
		[Required(ErrorMessage = "Şifrenizi Giriniz")]
		public string Password { get; set; }
	}
}
