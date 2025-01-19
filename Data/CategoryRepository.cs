using System;
using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public static class CategoryRepository
    {
        private static List<Category> _categories = new List<Category>();

        static CategoryRepository()
        {
           _categories = new List<Category>()
{
    new Category() { Id = 1, Name = "Action" },
    new Category() { Id = 2, Name = "Comedy" },
    new Category() { Id = 3, Name = "Drama" },
    new Category() { Id = 4, Name = "Horror" },
    new Category() { Id = 5, Name = "Romance" }
};


        }

        public static List<Category> Categories()
        {
            return _categories;
        }

        public static void AddCategory(Category entity)
        {
            _categories.Add(entity);
        }

        public static Category? GetById(int id)
{
    return _categories.FirstOrDefault(i => i.Id == id);
}
    }
}
