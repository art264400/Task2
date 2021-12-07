using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Task2.Attributes
{
    public class PhonesEqualAttribute : ValidationAttribute
    {

        public PhonesEqualAttribute()
            : base(() => SR.RequiredAttribute_ValidationError)
        {
        }

        /// <summary>
        ///     Gets or sets a flag indicating whether the attribute should allow empty strings.
        /// </summary>
        public bool AllowEmptyStrings { get; set; }

        /// <summary>
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }

            // only check string length if empty strings are not allowed
            return AllowEmptyStrings || !(value is string stringValue) || stringValue.Trim().Length != 0;
        }

        //public string OtherProperty { get; }

        //public override bool RequiresValidationContext => true;
        //public PhonesEqualAttribute(string otherProperty)
        //{
        //    OtherProperty = otherProperty;
        //    ErrorMessage = "Телефоны не должны совпадать";
        //}

        //protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        //{
        //    var otherPropertyInfo = validationContext.ObjectType.GetProperty(OtherProperty);
        //    return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
        //    //PersonalData p = value as PersonalData;
        //    if (otherPropertyInfo == null)
        //    {
        //        return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
        //    }
        //    if (otherPropertyInfo.GetIndexParameters().Any())
        //    {
        //        return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
        //    }
        //    object otherPropertyValue = otherPropertyInfo.GetValue(validationContext.ObjectInstance, null);

        //    if (Equals(value, otherPropertyValue))
        //    {
        //        //if (OtherPropertyDisplayName == null)
        //        //{
        //        //    OtherPropertyDisplayName = GetDisplayNameForProperty(otherPropertyInfo);
        //        //}

        //        return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
        //    }
        //    return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));

        //}

        //private string GetDisplayNameForProperty(PropertyInfo property)
        //{
        //    var attributes = CustomAttributeExtensions.GetCustomAttributes(property, true);
        //    var display = attributes.OfType<DisplayAttribute>().FirstOrDefault();
        //    if (display != null)
        //    {
        //        return display.GetName();
        //    }

        //    return OtherProperty;
        //}
    }
}
