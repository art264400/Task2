using System;

namespace Test
{
    public class Movie 
    {
        public Guid id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Duration { get; set; }

        public int MinAge { get; set; }

        public string ImgUrl { get; set; }

        public float Rating { get; set; }

        public Guid? CountryId { get; set; }

        public Country Country { get; set; }

    }
}
