using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookland.WebApplication.Models
{
    public class Book
    {
        public int Price { get; set; }
        public string ISBN { get; set; }
        public int Pages { get; set; }
    }
}