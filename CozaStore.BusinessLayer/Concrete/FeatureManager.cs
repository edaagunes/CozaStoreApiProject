﻿using CozaStore.BusinessLayer.Abstract;
using CozaStore.DataAccessLayer.Abstract;
using CozaStore.DataAccessLayer.EntityFramework;
using CozaStore.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozaStore.BusinessLayer.Concrete
{
	public class FeatureManager : IFeatureService
	{
		private readonly IFeatureDal _featureDal;

		public FeatureManager(IFeatureDal featureDal)
		{
			_featureDal = featureDal;
		}

		public void TDelete(int id)
		{
			_featureDal.Delete(id);
		}

		public List<Feature> TGetAll()
		{
			return _featureDal.GetAll();
		}

		public Feature TGetById(int id)
		{
			return _featureDal.GetById(id);
		}

		public void TInsert(Feature entity)
		{
			_featureDal.Insert(entity);
		}

		public void TUpdate(Feature entity)
		{
			_featureDal.Update(entity);
		}
	}
}
