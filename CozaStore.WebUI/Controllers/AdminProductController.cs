using CozaStore.WebUI.Dtos.CategoryDtos;
using CozaStore.WebUI.Dtos.ProductDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;
using X.PagedList.Extensions;

namespace CozaStore.WebUI.Controllers
{
	public class AdminProductController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public AdminProductController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		[HttpGet]
		public async Task<IActionResult> Index(int page = 1)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7043/api/Product/ProductListWithCategory");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultProductWithCategory>>(jsonData);
				var pagedValues = values.OrderBy(x=>x.ProductName).ToPagedList(page,6);
				return View(pagedValues);
			}
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> CreateProduct()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7043/api/Category");
			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);

			List<SelectListItem> values2 = (from x in values
											select new SelectListItem
											{
												Text = x.CategoryName,
												Value = x.CategoryId.ToString()
											}).ToList();

			ViewBag.v = values2;
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createProductDto);

			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("https://localhost:7043/api/Product", stringContent);

			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}

		public async Task<IActionResult> DeleteProduct(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync("https://localhost:7043/api/Product?id=" + id);

			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> UpdateProduct(int id)
		{
			var client = _httpClientFactory.CreateClient();

			var responseMessage = await client.GetAsync("https://localhost:7043/api/Category");

			var jsonData = await responseMessage.Content.ReadAsStringAsync();

			var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);

			List<SelectListItem> values2 = (from x in values
											select new SelectListItem
											{
												Text = x.CategoryName,
												Value = x.CategoryId.ToString()
											}).ToList();

			ViewBag.v = values2;


			var client2 = _httpClientFactory.CreateClient();
			var responseMessage2 = await client2.GetAsync("https://localhost:7043/api/Product/GetProduct?id=" + id);

			if (responseMessage2.IsSuccessStatusCode)
			{
				var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
				var updatedValue = JsonConvert.DeserializeObject<UpdateProductDto>(jsonData2);
				return View(updatedValue);
			}
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
		{
			var client = _httpClientFactory.CreateClient();

			var jsonData = JsonConvert.SerializeObject(updateProductDto);

			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PutAsync("https://localhost:7043/api/Product", stringContent);

			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}

			return View();
		}
	}
}
