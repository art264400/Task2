using EF.DataBase;
using EF.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;

namespace EF1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsetting.json");

            var config = builder.Build();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();

            var options = optionsBuilder.UseNpgsql(config["ConnectionStrings"]).Options ;


            using (ApplicationContext db = new ApplicationContext(options))
            {
                var movies = db.Movies.Include(c=>c.Country).ToList();
                
                var moviesGroup = db.Movies.GroupBy(c => c.Country.Name).Select(c => new
                {
                    c.Key,
                    Count = c.Count(),
                }).ToList();


                var timeslots = db.Timeslots.Include(c=>c.Movie).Join(db.Halls, c => c.HallId, u => u.Id, (c, u) => new
                {
                    MovieName= c.Movie.Title,
                    StartTime = c.StartTime,
                    HallName = u.Name
                }).ToList();

                var tarrifs = db.Tariffs.Where(c => c.Cost > 250)
                    .Union(db.Tariffs.Where((c) => c.Cost < 200)).ToList();
           
            }
        }
    }
}
