using Microsoft.AspNetCore.Mvc;

namespace CozaStore.WebUI.ViewComponents.Default
{
	public class _BannerLayout : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
