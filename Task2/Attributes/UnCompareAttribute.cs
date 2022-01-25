using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Task2.Attributes
{
    public class UnCompareAttribute : ValidationAttribute, IClientModelValidator
    {
        private string OtherProperty { get; set; }
        public UnCompareAttribute(string otherProperty)
        {
            OtherProperty = otherProperty;
            ErrorMessage = "Телефоны не должны совпадать";
        }
        public UnCompareAttribute(string otherProperty, string errorMessage)
        {
            OtherProperty=otherProperty;
            ErrorMessage = errorMessage;
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            MergeAttribute(context.Attributes, "data-val", "true");
            MergeAttribute(context.Attributes, "data-val-uncompare", ErrorMessage);
            MergeAttribute(context.Attributes, "data-val-uncompare-other", OtherProperty);
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var otherPropertyInfo = validationContext.ObjectType.GetRuntimeProperty(OtherProperty);
            if (otherPropertyInfo == null)
            {
                return new ValidationResult("Не найдено свойство");
            }
            var otherPropertyValue = otherPropertyInfo.GetValue(validationContext.ObjectInstance);
            if(Equals(value, otherPropertyValue))
            {
                return new ValidationResult(ErrorMessage);
            }
          
            return ValidationResult.Success;
        }
        private bool MergeAttribute(IDictionary<string, string> attributes, string key, string value)
        {
            if (attributes.ContainsKey(key))
            {
                return false;
            }

            attributes.Add(key, value);
            return true;
        }
    }
}
