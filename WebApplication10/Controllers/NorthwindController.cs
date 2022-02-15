using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication10.Models;


namespace WebApplication10.Controllers
{
    public class NorthwindController : Controller
    {
        private string _connectionString = @"Data Source=.\sqlexpress;Initial Catalog=Northwnd;Integrated Security=true;";

        public ActionResult Orders()
        {
            NorthwindDb db = new NorthwindDb(_connectionString);
            List<Order> orders = db.GetOrders();

            OrdersPageViewModel vm = new OrdersPageViewModel
            {
                Orders = orders,
                DisplayDate = DateTime.Now
            };

            return View(vm);
        }

        public ActionResult OrderDetails(int year)
        {
            NorthwindDb db = new NorthwindDb(_connectionString);
            List<OrderDetail> orderDetails = db.GetOrdersDetails(year);

            return View(orderDetails);
        }

        public ActionResult OrdersByYear(int year, string country)
        {
            NorthwindDb db = new NorthwindDb(_connectionString);
            List<Order> orders = db.GetOrdersByYear(year, country);

            OrdersByYearViewModel vm = new OrdersByYearViewModel
            {
                Orders = orders,
                Year = year
            };

            return View(vm);
        }

        public ActionResult Categories()
        {
            NorthwindDb db = new NorthwindDb(_connectionString);
            List<Category> categories = db.GetCategories();

            CategoriesViewModel vm = new CategoriesViewModel
            {
                Categories = categories
            };

            return View(vm);
        }

        public ActionResult Products(int categoryId = 1)
        {
            NorthwindDb db = new NorthwindDb(_connectionString);
            List<Product> products = db.GetProducts(categoryId);

            ProductsViewModel vm = new ProductsViewModel
            {
                Products = products,
                CategoryName = db.GetCategoryName(categoryId)
            };


            return View(vm);
        }

        public ActionResult ProductSearch()
        {
            return View();
        }

        public ActionResult ShowProductSearchResults(string searchText)
        {
            NorthwindDb db = new NorthwindDb(_connectionString);
            List<Product> products = db.SearchProducts(searchText);

            ProductSearchViewModel vm = new ProductSearchViewModel
            {
                SearchText = searchText,
                Products = products
            };
            return View(vm);
        }
    }
}

//Create an application that has two pages:
// /northwind/categories
// /northwind/products

//On the categories page, display a list of all categories in the northwind database
//(id, name, description). The name of the category should be a link, that when clicked
//takes the user to the products page. On the products page, only the products
//for the category that was clicked on should be displayed. Additionally, on top of
//the products page, have an H1 that says "Products for Category {CategoryName}"