using Microsoft.AspNetCore.Mvc;

namespace CozaStore.WebUI.Controllers
{
	public class AdminDashboardController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
