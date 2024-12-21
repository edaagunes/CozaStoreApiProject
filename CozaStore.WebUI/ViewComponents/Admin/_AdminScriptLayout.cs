using Microsoft.AspNetCore.Mvc;

namespace CozaStore.WebUI.ViewComponents.Admin
{
	public class _AdminScriptLayout : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
