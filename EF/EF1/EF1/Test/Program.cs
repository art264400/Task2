using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Test.Context;
using Test.Repository;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (ApplicationContext db = new ApplicationContext())
            {
                var repos = new GenericRepository<Movie>(db);
                var movies = repos.Get();            

                var repos2 = new GenericRepository<Country>(db);
                var countries = repos2.Get();
            }

            //using (ApplicationContext db = new ApplicationContext())
            //{
            //    db.movies.Add(new Movie
            //    {
            //        Country = new Country
            //        {
            //            Name = "Russia",
            //            CountryCode = "Rus",
            //            id = Guid.NewGuid()
            //        },
            //        id = Guid.NewGuid(),
            //        Description = "описание",
            //        Duration = 110,
            //        ImgUrl = "Url",
            //        Rating = 3.7f,
            //        MinAge = 16,
            //        Title = "Веном"
            //    });
            //    db.movies.Add(new Movie
            //    {
            //        Country = new Country
            //        {
            //            Name = "USA",
            //            CountryCode = "US",
            //            id = Guid.NewGuid()
            //        },
            //        id = Guid.NewGuid(),
            //        Description = "ВТОПРОЙ ФИЛЬМ",
            //        Duration = 150,
            //        ImgUrl = "Url",
            //        Rating = 3.3f,
            //        MinAge = 16,
            //        Title = "Веном 2"
            //    });
            //    var movies = db.movies.Include(c => c.Country).ToList();
            //    db.SaveChanges();
            //}
        }
    }
}
