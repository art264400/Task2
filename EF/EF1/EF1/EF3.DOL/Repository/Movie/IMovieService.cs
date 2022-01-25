using System;
using System.Collections.Generic;
using EF.DataBase.Entities;

namespace EF3.DAL.Repository
{
    interface IMovieService
    {
        List<Movie> GetAll();

        Movie Get(Guid id);

        Movie GetByTitle(string title);
    }
}
