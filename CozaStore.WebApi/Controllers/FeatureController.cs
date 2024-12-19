using CozaStore.BusinessLayer.Abstract;
using CozaStore.DtoLayer.CategoryDtos;
using CozaStore.DtoLayer.FeatureDtos;
using CozaStore.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CozaStore.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FeatureController : ControllerBase
	{
		private readonly IFeatureService _featureService;

		public FeatureController(IFeatureService featureService)
		{
			_featureService = featureService;
		}

		[HttpGet]
		public IActionResult FeatureList()
		{
			var values = _featureService.TGetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
		{
			Feature feature = new Feature();
			feature.Head = createFeatureDto.Head;
			feature.Title = createFeatureDto.Title;
			feature.ImageUrl = createFeatureDto.ImageUrl;
			_featureService.TInsert(feature);
			return Ok("Ekleme başarılı");
		}

		[HttpPut]
		public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
		{
			Feature feature = new Feature();
			feature.FeatureId = updateFeatureDto.FeatureId;
			feature.Head = updateFeatureDto.Head;
			feature.Title = updateFeatureDto.Title;
			feature.ImageUrl = updateFeatureDto.ImageUrl;
			_featureService.TUpdate(feature);
			return Ok("Güncelleme Başarılı");
		}

		[HttpGet("GetFeature")]
		public IActionResult GetFeature(int id)
		{
			var value = _featureService.TGetById(id);
			return Ok(value);
		}


		[HttpDelete]
		public IActionResult DeleteFeature(int id)
		{
			_featureService.TDelete(id);
			return Ok("Silme Başarılı");
		}
	}
}
