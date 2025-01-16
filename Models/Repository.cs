using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Models
{
    public static class Repository
    {
        private static List<Movie> _movies = null;

        static Repository()
        {
            _movies = new List<Movie>()
            {
                new Movie { Id = 1, Name = "Inception", Description = "A sci-fi movie", ImageUrl = "inception.jpg" },
                new Movie { Id = 2, Name = "Interstellar", Description = "A space exploration movie", ImageUrl = "interstellar.jpg" },
                new Movie { Id = 3, Name = "The Dark Knight", Description = "A superhero movie", ImageUrl = "darkknight.jpg" },
                new Movie { Id = 4, Name = "Avatar", Description = "A fantasy adventure movie", ImageUrl = "avatar.jpg" },
                new Movie { Id = 5, Name = "Titanic", Description = "A historical romance movie", ImageUrl = "titanic.jpg" },
                new Movie { Id = 6, Name = "Joker", Description = "A psychological thriller movie", ImageUrl = "joker.jpg" }
            };
        }

        public static List<Movie> Movies()
        {
            return _movies;
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}
