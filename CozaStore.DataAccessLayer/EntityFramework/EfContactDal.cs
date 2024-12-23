﻿using CozaStore.DataAccessLayer.Abstract;
using CozaStore.DataAccessLayer.Context;
using CozaStore.DataAccessLayer.Repositories;
using CozaStore.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozaStore.DataAccessLayer.EntityFramework
{
	public class EfContactDal : GenericRepository<Contact>, IContactDal
	{
		public EfContactDal(CozaContext context) : base(context)
		{
		}

		public Contact LastMessage()
		{
			using (var context = new CozaContext())
			{
				var lastMessage = context.Contacts
										 .OrderByDescending(p => p.ContactId)
										 .FirstOrDefault();
				return lastMessage;
			}
		}
	}
}
