using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication10.Models
{
    public class OrdersByYearViewModel
    {
        public List<Order> Orders { get; set; }
        public int Year { get; set; }
    }
}