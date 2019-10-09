using System;
using System.ComponentModel.DataAnnotations;

namespace ChatWithMe.Web.ValidationAttributes
{
    public class NotEqualAttribute : ValidationAttribute
    {
        private string _propertyName { get; set; }

        public NotEqualAttribute(string propertyName)
        {
            _propertyName = propertyName;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var selectedPropertyValue = (string) value;

            var targetProperty = validationContext.ObjectType.GetProperty(_propertyName);

            if (targetProperty == null)
            {
                throw new ArgumentException(nameof(_propertyName));
            }

            var targetPropertyValue = (string) targetProperty.GetValue(validationContext.ObjectInstance);

            if (selectedPropertyValue != targetPropertyValue)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(ErrorMessage);
        }
    }
}
