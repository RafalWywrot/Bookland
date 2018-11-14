using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookland.WebApplication.Helpers.Filters
{
    public class LengthValidationAttribute : ValidationAttribute
    {
        private int _maxLength;
        public LengthValidationAttribute(int maxLength)
        {
            _maxLength = maxLength;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }
            if (value.ToString().Count() > _maxLength)
            {
                return new ValidationResult(String.Format("Dlugosc tekstu nie może przekraczać {0} znaków", _maxLength ));
            }
            return ValidationResult.Success;
        }
    }
}