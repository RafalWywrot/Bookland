using Bookland.WebApplication.Helpers.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookland.WebApplication.Models
{
    public class Book
    {
        [Display(Name = "Cena")]
        [Required(ErrorMessage = "Wypelnij poprawnie pole {0}")]
        public int Price { get; set; }
        [LengthValidationAttribute(5)]
        public string ISBN { get; set; }
        [Range(2.5, 10.0, ErrorMessage = "Niepoprawna wartosc {0}")]
        public int Pages { get; set; }
    }
}