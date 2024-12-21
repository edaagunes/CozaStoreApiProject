using Microsoft.AspNetCore.Mvc;

namespace CozaStore.WebUI.ViewComponents.Admin
{
	public class _AdminSidebarLayout : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
