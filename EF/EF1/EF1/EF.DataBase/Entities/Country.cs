using EF.Common;

namespace EF.DataBase.Entities
{
    public class Country : EntityBase
    {
        public string Name { get; set; }

        public string CountryCode { get; set; }
    }
}