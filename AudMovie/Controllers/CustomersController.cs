using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AudMovie.Models;

namespace AudMovie.Controllers
{
    public class CustomersController : Controller
    {
		//private MyDbContext myDbContext;
        // GET: Customers
        public ActionResult Index()
        {
			var customer = new List<Customer>
			{
				new Customer
				{
					Id = 1, Name = "Denis Semko"
				},
				new Customer
				{
					Id = 2, Name = "Sonechka Bykovska"
				}
			};
			return View(customer);
        }
		public ActionResult Details(int id)
		{
			var customer = new List<Customer>
			{
				new Customer
				{
					Id = 1, Name = "Denis Semko"
				},
				new Customer
				{
					Id = 2, Name = "Sonechka Bykovska"
				}
			}.SingleOrDefault(c => c.Id == id);
			return View(customer);
		}
	}
}