﻿using App.Business.Abstract;
using App.Data.Abstract;
using App.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Concrete
{
	public class CategoryManager : ICategoryService
	{
		ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public void TAdd(Category t)
		{
			_categoryDal.Insert(t);
		}

		public void TDelete(Category t)
		{
			_categoryDal.Delete(t);
		}

		public Category TGetByID(int id)
		{
			return _categoryDal.GetByID(id);
		}

		public List<Category> TGetList()
		{
			return _categoryDal.GetList();
		}

		public List<Category> TGetListbyFilter(Expression<Func<Category, bool>> filter)
		{
			return _categoryDal.GetByFilter(filter);
		}

		public void TUpdate(Category t)
		{
			_categoryDal.Update(t);
		}
	}
}
