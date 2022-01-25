using EF.Common;
using System;

namespace EF.DataBase.Entities
{
    public class Timeslot : EntityBase
    {
        public DateTime StartTime { get; set; } 

        public Guid? TariffId { get; set; }

        public Tariff Tariff { get; set; }

        public Guid MovieId { get; set; }

        public Movie Movie { get; set; }

        public Guid HallId { get; set; }

        public Hall Hall { get; set; }
    }
}
