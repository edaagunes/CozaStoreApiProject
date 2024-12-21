using Microsoft.AspNetCore.Mvc;

namespace CozaStore.WebUI.ViewComponents.Admin
{
	public class _AdminHeaderLayout : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
