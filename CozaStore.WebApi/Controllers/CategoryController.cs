using CozaStore.BusinessLayer.Abstract;
using CozaStore.DtoLayer.CategoryDtos;
using CozaStore.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CozaStore.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoryService _categoryService;

		public CategoryController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		[HttpGet]
		public IActionResult CategoryList()
		{
			var values = _categoryService.TGetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
		{
			Category category = new Category();
			category.CategoryName = createCategoryDto.CategoryName;
			category.Title = createCategoryDto.Title;
			category.ImageUrl = createCategoryDto.ImageUrl;

			_categoryService.TInsert(category);
			return Ok("Ekleme başarılı");
		}

		[HttpPut]
		public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
		{
			Category category = new Category();
			category.CategoryId = updateCategoryDto.CategoryId;
			category.CategoryName = updateCategoryDto.CategoryName;
			category.Title = updateCategoryDto.Title;
			category.ImageUrl = updateCategoryDto.ImageUrl;

			_categoryService.TUpdate(category);
			return Ok("Güncelleme Başarılı");
		}

		[HttpGet("GetCategory")]
		public IActionResult GetCategory(int id)
		{
			var value = _categoryService.TGetById(id);
			return Ok(value);
		}


		[HttpDelete]
		public IActionResult DeleteCategory(int id)
		{
			_categoryService.TDelete(id);
			return Ok("Silme Başarılı");
		}
	}
}
