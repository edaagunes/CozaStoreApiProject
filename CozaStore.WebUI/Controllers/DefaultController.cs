using CozaStore.WebUI.Dtos.ProductDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace CozaStore.WebUI.Controllers
{
	public class DefaultController : Controller
	{
		//private readonly IHttpClientFactory _httpClientFactory;

		//public DefaultController(IHttpClientFactory httpClientFactory)
		//{
		//	_httpClientFactory = httpClientFactory;
		//}
		public IActionResult Index()
		{
			return View();
		}

		//[HttpGet]
		//public async Task<IActionResult> GetProductDetails(int id)
		//{
		//	var client = _httpClientFactory.CreateClient();
		//	var responseMessage = await client.GetAsync($"https://localhost:7043/api/Product/GetProduct?id={id}");

		//	if (responseMessage.IsSuccessStatusCode)
		//	{
		//		var jsonData = await responseMessage.Content.ReadAsStringAsync();
		//		var values = JsonConvert.DeserializeObject<ResultProductWithGetById>(jsonData);
		//		return PartialView("GetProductDetails", values);
		//	}

		//	return View();
		//}

	}
}
