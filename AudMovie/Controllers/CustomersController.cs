using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AudMovie.Models;
using System.Data.Entity;

namespace AudMovie.Controllers
{
    public class CustomersController : Controller
    {
		private MyDbContext myDbContext;
		public CustomersController()
		{
			myDbContext = new MyDbContext();
		}
		protected override void Dispose(bool disposing)
		{
			myDbContext.Dispose();
		}
        // GET: Customers
        public ActionResult Index()
        {
			var customer = myDbContext.Customers.Include(c => c.MembershipType).ToList();
			return View(customer);
        }
		public ActionResult Details(int id)
		{
			var customer = myDbContext.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
			return View(customer);
		}
	}
}