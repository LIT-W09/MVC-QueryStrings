using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication10.Models
{
    public class OrdersPageViewModel
    {
        public List<Order> Orders { get; set; }
        public DateTime DisplayDate { get; set; }
    }
}