using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValidateForm.Models
{
    public class Product
    {
        private int _id;
        private string _name;
        private string _price;

        public int id
        {
            get => _id;
            set => _id = value;
        }
        [name]
        public string name
        {
            get => _name;
            set => _name = value;
        }

        public string price
        {
            get => _price;
            set => _price = value;
        }

        public class nameAttribute : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                Product p = (Product) validationContext.ObjectInstance;

                if (p.name.Contains("sex") || p.name.Contains("porn"))
                {
                    return new ValidationResult("Không được chứa nội dung nhậy cảm");
                }

                return ValidationResult.Success;
            }
        }
    }
}
