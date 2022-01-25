using EF.DataBase;
using EF.DataBase.Entities;
using EF3.Generic.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;

namespace EF3.Generic
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

            var options = optionsBuilder.UseNpgsql(config["ConnectionStrings"]).Options;

            EFGenericRepository<Movie> movies = new EFGenericRepository<Movie>(new ApplicationContext(options));

            EFGenericRepository<Hall> halls = new EFGenericRepository<Hall>(new ApplicationContext(options));

            var hall = halls.Get(c => c.Name == "Hall 1");
            var movie = movies.Get(c=>c.Title=="ВЕНОМ").FirstOrDefault();


            Console.WriteLine(movie);
        }
    }
}
