using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication10.Models
{
    public class ProductsViewModel
    {
        public List<Product> Products { get; set; }
        public string CategoryName { get; set; }
    }
}