﻿using Business.Abstract;
using DataAccess.Abstract;
using Entiities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public Category Get(int categoryId)
        {
            return _categoryDal.Get(categoryId);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}