using EF.DataBase.Entities;
using System;
using System.Collections.Generic;

namespace EF3.DAL.Repository
{
    interface ITimeslotService
    {
        List<Timeslot> GetAll();

        Timeslot Get(Guid id);

        Timeslot GetBy(string title);
    }
}
