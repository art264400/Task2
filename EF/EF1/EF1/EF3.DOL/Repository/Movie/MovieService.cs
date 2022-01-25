using EF.DataBase;
using EF.DataBase.Entities;
using EF3.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EF3.DAL
{
    public class MovieService : IMovieService
    {
        DbContextOptions<ApplicationContext> _options;

        public MovieService(DbContextOptions<ApplicationContext> options)
        {
            _options = options;
        }

        public Movie Get(Guid id)
        {
            using (var db = new ApplicationContext(_options))
            {
               return db.Movies.FirstOrDefault(x => x.Id == id);
            }
        }

        public List<Movie> GetAll()
        {
            using (var db = new ApplicationContext(_options))
            {
                return db.Movies.ToList();
            }
        }

        public Movie GetByTitle(string title)
        {
            using (var db = new ApplicationContext(_options))
            {
                return db.Movies.FirstOrDefault(x => x.Title.Contains(title));
            }
        }
    }
}
