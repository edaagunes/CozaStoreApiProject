using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozaStore.DtoLayer.ContactDtos
{
	public class CreateContactDto
	{
		public string SenderMail { get; set; }
		public string Message { get; set; }
	}
}
