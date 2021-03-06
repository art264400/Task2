using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Task2.Attributes;

namespace Task2.Models
{
    public class PersonalData
    {
        public Division Division { get; set; }

        [Required]
        [DisplayName("Подразделение")]
        public int DivisionId { get; set; }

        public Position Position { get; set; }

        [Required]
        [DisplayName("Должность")]
        public int PositionId { get; set; }

        [Required]
        [DisplayName("Добавочный телефон 1")]
        [RegularExpression(@"^((8 |\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$", ErrorMessage = "Неправильный номер телефона")]
        public string PhoneNumberFirst { get; set; }


        [Required]
        [DisplayName("Добавочный телефон 2")]
        [RegularExpression(@"^((8 |\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$", ErrorMessage = "Неправильный номер телефона")]
        [PhonesEqual("PhoneNumberFirst")]
        public string PhoneNumberSecond { get; set; }

        [Required]
        [DisplayName("Адрес офиса")]
        [MaxLength(100)]
        public string OfficeAddress { get; set; }

        [Required]
        [DisplayName("Кабинет")]
        public string Cabinet { get; set; }

        [Required]
        [DisplayName("Комментарий")]
        [StringLength(2000)]
        public string Comment { get; set; }

    }

    public class Division
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class XmlList
    {
        public List<Position> Positions { get; set; }

        public List<Division> Divisions { get; set; }

        public string GetXml()
        {
            return this.ToXml();
        }
    }

    public class PersonalDataList
    {
        public List<PersonalData> PersonalDatas { get; set; }
    }
}
