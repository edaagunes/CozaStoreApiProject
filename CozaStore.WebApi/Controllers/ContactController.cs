using CozaStore.BusinessLayer.Abstract;
using CozaStore.DtoLayer.CategoryDtos;
using CozaStore.DtoLayer.ContactDtos;
using CozaStore.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CozaStore.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContactController : ControllerBase
	{
		private readonly IContactService _contactService;

		public ContactController(IContactService contactService)
		{
			_contactService = contactService;
		}

		[HttpGet]
		public IActionResult ContactList()
		{
			var values = _contactService.TGetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateContact(CreateContactDto createContactDto)
		{
			Contact contact = new Contact();		
			contact.SenderMail = createContactDto.SenderMail;
			contact.Message = createContactDto.Message;

			_contactService.TInsert(contact);
			return Ok("Ekleme başarılı");
		}

		[HttpPut]
		public IActionResult UpdateContact(UpdateContactDto updateContactDto)
		{
			Contact contact = new Contact();
			contact.ContactId = updateContactDto.ContactId;
			contact.SenderMail = updateContactDto.SenderMail;
			contact.Message = updateContactDto.Message;

			_contactService.TUpdate(contact);
			return Ok("Güncelleme Başarılı");
		}

		[HttpGet("GetContact")]
		public IActionResult GetContact(int id)
		{
			var value = _contactService.TGetById(id);
			return Ok(value);
		}


		[HttpDelete]
		public IActionResult DeleteContact(int id)
		{
			_contactService.TDelete(id);
			return Ok("Silme Başarılı");
		}
	}
}
