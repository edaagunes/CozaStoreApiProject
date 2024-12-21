using CozaStore.BusinessLayer.Abstract;
using CozaStore.DataAccessLayer.Context;
using CozaStore.DtoLayer.ProductDtos;
using CozaStore.EntityLayer.Concrete;
using CozaStore.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CozaStore.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductService _productService;

		public ProductController(IProductService productService)
		{
			_productService = productService;
		}

		[HttpGet]
		public IActionResult ProductList()
		{
			var values = _productService.TGetAll();
			return Ok(values);
		}

		[HttpGet("ProductListWithCategory")]
		public IActionResult ProductListWithCategory()
		{
			CozaContext context = new CozaContext();
			var values = context.Products.Include(x => x.Category).Select(y => new ProductWithCategoryViewModel
			{
				ProductId = y.ProductId,
				ProductName = y.ProductName,
				Price = y.Price,
				Detail = y.Detail,
				ImageUrl = y.ImageUrl,
				CategoryName = y.Category.CategoryName,
				CategoryId = y.CategoryId
			}).ToList();
			
			return Ok(values);

		}

		[HttpGet("GetProduct")]
		public IActionResult GetProduct(int id)
		{
			var value = _productService.TGetById(id);
			return Ok(value);
		}

		[HttpPost]
		public IActionResult CreateProduct(CreateProductDto createProductDto)
		{
			Product product = new Product();
			product.ProductName = createProductDto.ProductName;
			product.Price = createProductDto.Price;
			product.Detail = createProductDto.Detail;
			product.ImageUrl = createProductDto.ImageUrl;
			product.CategoryId = createProductDto.CategoryId;
			_productService.TInsert(product);
			return Ok("Ekleme başarılı");
		}

		[HttpPut]
		public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
		{
			Product product = new Product();
			product.ProductId = updateProductDto.ProductId;
			product.ProductName = updateProductDto.ProductName;
			product.Price = updateProductDto.Price;
			product.Detail = updateProductDto.Detail;
			product.ImageUrl = updateProductDto.ImageUrl;
			product.CategoryId = updateProductDto.CategoryId;
			_productService.TUpdate(product);
			return Ok("Güncelleme Başarılı");
		}

		[HttpDelete]
		public IActionResult DeleteCategory(int id)
		{
			_productService.TDelete(id);
			return Ok("Silme Başarılı");
		}
		[HttpGet("ProductCount")]
		public IActionResult ProductCount()
		{
			var value = _productService.TProductCount();
			return Ok(value);
		}
		[HttpGet("LastProduct")]
		public IActionResult LastProduct()
		{
			var value = _productService.TGetLastProduct();
			return Ok(value);
		}
		[HttpGet("GetLast4Product")]
		public IActionResult GetLast4Product()
		{
			var value = _productService.TGetLast4Products();
			return Ok(value);
		}
	}
}
