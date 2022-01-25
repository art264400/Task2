using EF.Common;
using EF.Common.Enums;
using System;

namespace EF.DataBase.Entities
{
    public class Movie : EntityBase
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int Duration { get; set; }

        public Genre[] Genres { get; set; }

        public int MinAge { get; set; }

        public string ImgUrl { get; set; }  

        public float Rating { get; set; }

        public Guid? CountryId { get; set; }

        public Country Country { get; set; }

        public override string ToString()
        {
            return Title + "(" + Description + ")";
        }

    }
}
