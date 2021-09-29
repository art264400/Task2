using System.ComponentModel.DataAnnotations;
using Task2.Models;

namespace Task2.Attributes
{
    public class PhonesEqualAttribute : ValidationAttribute
    {
        public PhonesEqualAttribute()
        {
            ErrorMessage = "Телефоны не должны совпадать";
        }

        public override bool IsValid(object value)
        {
            PersonalData p = value as PersonalData;

            if (p.PhoneNumberFirst == p.PhoneNumberSecond)
            {
                return false;
            }
            return true;
        }
    }
}
