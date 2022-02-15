using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication10.Models
{
    public class ProductSearchViewModel
    {
        public List<Product> Products { get; set; }
        public string SearchText { get; set; }
    }
}