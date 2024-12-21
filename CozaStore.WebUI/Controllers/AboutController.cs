using CozaStore.WebUI.Dtos.AboutDtos;
using CozaStore.WebUI.Dtos.CategoryDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CozaStore.WebUI.Controllers
{
	public class AboutController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public AboutController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();

			var responseMessage = await client.GetAsync("https://localhost:7043/api/About");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<ResultAboutDto>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}
