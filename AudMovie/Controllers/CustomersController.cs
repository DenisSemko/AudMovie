using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AudMovie.Models;
using System.Data.Entity;
using AudMovie.ViewModels;


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
		public ActionResult New()
		{
			var membershipType = myDbContext.MembershipTypes.ToList();
			var viewModel = new NewCustomerViewModel
			{
				MembershipTypes = membershipType
			};

			return View(viewModel);
		}

		[HttpPost]
		public ActionResult Save(Customer customer)
		{
			if(customer.Id == 0)
			{
				myDbContext.Customers.Add(customer);
			} else
			{
				var customerInDb = myDbContext.Customers.Single(c => c.Id == customer.Id);

				customerInDb.Name = customer.Name;
				customerInDb.BirthDate = customer.BirthDate;
				customerInDb.MembershipTypeId = customer.MembershipTypeId;
				customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
				customerInDb.Name = customer.Name;

			}
			myDbContext.SaveChanges();
			return RedirectToAction("Index", "Customers");
		}

		public ActionResult Edit(int id)
		{
			var customer = myDbContext.Customers.SingleOrDefault(c => c.Id == id);

			if(customer == null)
			{
				return HttpNotFound();
			}

			var viewModel = new NewCustomerViewModel
			{
				Customer = customer,
				MembershipTypes = myDbContext.MembershipTypes.ToList()
			};

			return View("New", viewModel);

		}
	}
}