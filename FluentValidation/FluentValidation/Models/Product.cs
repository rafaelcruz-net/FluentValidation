using FluentValidation.Attributes;
using FluentValidationSample.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentValidationSample.Models
{
    [Validator(typeof(ProductValidator))]
    public class Product
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime CreateDate { get; set; }
        public Decimal Price { get; set; }
    }
}