using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult FormDemo()
        {
            return View();
        }

        public ActionResult FormSubmit(string myValue)
        {
            FormSubmitViewModel vm = new FormSubmitViewModel
            {
                Value = myValue
            };
            return View(vm);
        }
        
    }
}