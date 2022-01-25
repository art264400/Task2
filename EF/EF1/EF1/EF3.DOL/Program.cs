using EF.DataBase;
using EF3.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace EF3.DAL
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

            IMovieService movieDAL = new MovieService(options);

            var movies = movieDAL.GetAll();

        }
    }
}
