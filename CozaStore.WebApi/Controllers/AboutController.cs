using CozaStore.BusinessLayer.Abstract;
using CozaStore.DtoLayer.AboutDtos;
using CozaStore.DtoLayer.CategoryDtos;
using CozaStore.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CozaStore.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AboutController : ControllerBase
	{
		private readonly IAboutService _aboutService;

		public AboutController(IAboutService aboutService)
		{
			_aboutService = aboutService;
		}

		[HttpGet]
		public IActionResult AboutList()
		{
			var values = _aboutService.TGetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateAbout(CreateAboutDto createAboutDto)
		{
			About about = new About();
			about.QuoteAuthor = createAboutDto.QuoteAuthor;
			about.QuoteDetail = createAboutDto.QuoteDetail;
			about.OurMissionDetail = createAboutDto.OurMissionDetail;
			about.Image1 = createAboutDto.Image1;
			about.Image2 = createAboutDto.Image2;
			about.CoverImage = createAboutDto.CoverImage;
			about.OurStoryDetail = createAboutDto.OurStoryDetail;

			_aboutService.TInsert(about);
			return Ok("Ekleme başarılı");
		}

		[HttpPut]
		public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
		{
			About about = new About();
			about.AboutId = updateAboutDto.AboutId;
			about.QuoteAuthor = updateAboutDto.QuoteAuthor;
			about.QuoteDetail = updateAboutDto.QuoteDetail;
			about.OurMissionDetail = updateAboutDto.OurMissionDetail;
			about.Image1 = updateAboutDto.Image1;
			about.Image2 = updateAboutDto.Image2;
			about.CoverImage = updateAboutDto.CoverImage;
			about.OurStoryDetail = updateAboutDto.OurStoryDetail;

			_aboutService.TUpdate(about);
			return Ok("Güncelleme Başarılı");
		}

		[HttpGet("GetAbout")]
		public IActionResult GetAbout(int id)
		{
			var value = _aboutService.TGetById(id);
			return Ok(value);
		}

	}
}
