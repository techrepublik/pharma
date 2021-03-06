﻿using System.Collections.Generic;
using System.Linq;
using PharmaPos.data;

namespace PharmaPos.dal.man
{
    class CategoryManager
    {
        public static DataRepository<Category> _d;

        public static int Save(Category category)
        {
            var a = new Category
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName
            };

            using (_d = new DataRepository<Category>())
            {
                if (category.CategoryId > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.CategoryId;
        }

        public static bool Delete(Category category)
        {
            using (_d = new DataRepository<Category>())
            {
                _d.Delete(category);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Category>())
            {
                _d.Delete(d => d.CategoryId == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Category> GetAll()
        {
            using (_d = new DataRepository<Category>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }
    }
}
