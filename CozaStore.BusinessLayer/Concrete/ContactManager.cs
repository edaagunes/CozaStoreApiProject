﻿using CozaStore.BusinessLayer.Abstract;
using CozaStore.DataAccessLayer.Abstract;
using CozaStore.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozaStore.BusinessLayer.Concrete
{
	public class ContactManager : IContactService
	{
		private readonly IContactDal _contactDal;

		public ContactManager(IContactDal contactDal)
		{
			_contactDal = contactDal;
		}

		public void TDelete(int id)
		{
			_contactDal.Delete(id);
		}

		public List<Contact> TGetAll()
		{
			return _contactDal.GetAll();
		}

		public Contact TGetById(int id)
		{
			return _contactDal.GetById(id);
		}

		public void TInsert(Contact entity)
		{
			_contactDal.Insert(entity);
		}

		public Contact TLastMessage()
		{
			return _contactDal.LastMessage();
		}

		public void TUpdate(Contact entity)
		{
			_contactDal.Update(entity);
		}
	}
}
