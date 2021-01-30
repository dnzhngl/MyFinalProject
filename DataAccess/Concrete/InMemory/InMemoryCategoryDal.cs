﻿using DataAccess.Abstract;
using Entiities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{

    public class InMemoryCategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public InMemoryCategoryDal()
        {
            _categories = new List<Category>
            {
                new Category{ CategoryId=1, CategoryName="Züccaciye" },
                new Category{ CategoryId=2, CategoryName="Elektronik" },
            };
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            var categoryToDelete = _categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);
            _categories.Remove(categoryToDelete);
        }

        public Category Get(int categoryId)
        {
            var category = _categories.SingleOrDefault(c => c.CategoryId == categoryId);
            return category;
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category category)
        {
            var categoryToUpdate = _categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);
            categoryToUpdate.CategoryName = category.CategoryName;
        }
    }
}