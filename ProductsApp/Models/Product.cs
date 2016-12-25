using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        public string Price { get; set; }
        public string Author { get; set; }
    }
}