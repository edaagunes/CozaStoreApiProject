using Microsoft.AspNetCore.Mvc;

namespace CozaStore.WebUI.ViewComponents.Admin
{
	public class _AdminHeadLayout:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
