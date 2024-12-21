using CozaStore.EntityLayer.Concrete;
using CozaStore.WebUI.Dtos.AdminDtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CozaStore.WebUI.Controllers
{
	public class LoginController : Controller
	{
		private readonly SignInManager<AppUser> _signInManager;

		public LoginController(SignInManager<AppUser> signInManager)
		{
			_signInManager = signInManager;
		}
		[HttpGet]

		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Index(LoginUserDto loginUserDto)
		{
			if (ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(loginUserDto.Username, loginUserDto.Password, false, false);
				if (result.Succeeded)
				{
					return RedirectToAction("Index", "AdminDashboard");
				}
				else
				{
					return View();
				}
			}
			return View();
		}
	}
}
