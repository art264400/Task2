using EF.Common;


namespace EF.DataBase.Entities
{
    public class Tariff : EntityBase
    {
        public string Name { get; set; }

        public decimal Cost { get; set; }
    }
}
