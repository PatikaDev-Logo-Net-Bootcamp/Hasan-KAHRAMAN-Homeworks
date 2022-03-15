using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Homework1.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MaxFileSizeAttribute : ValidationAttribute
    {
        private readonly int _maxFileSize;
        public MaxFileSizeAttribute(int maxFileSize)
        {

        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (!(value is IFormFile file) )
            {
                return ValidationResult.Success;
            }
            return file.Length > _maxFileSize ? new ValidationResult($"dosya boyutu maxsimum {_maxFileSize} byte olabilir.") : ValidationResult.Success;
        }
    }
}
