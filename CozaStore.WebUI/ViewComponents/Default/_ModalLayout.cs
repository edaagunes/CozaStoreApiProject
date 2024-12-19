using CozaStore.WebUI.Dtos.ProductDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CozaStore.WebUI.ViewComponents.Default
{
	public class _ModalLayout : ViewComponent
	{

		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
