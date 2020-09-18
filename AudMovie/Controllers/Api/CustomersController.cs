using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AudMovie.Models;
using AudMovie.Dtos;
using AutoMapper;

namespace AudMovie.Controllers.Api
{
    public class CustomersController : ApiController
    {
		private MyDbContext applicationDbContext;
		public CustomersController()
		{
			applicationDbContext = new MyDbContext();
		}
		// Get /api/customers
		public IHttpActionResult GetCustomers()
		{
			return Ok(applicationDbContext.Customers.ToList().Select(Mapper.Map<Customer, CustomerDtos>));
		}

		// Get /api/customers/1
		public IHttpActionResult GetCustomer(int id)
		{
			var customer = applicationDbContext.Customers.SingleOrDefault(c => c.Id == id);

			if(customer == null)
			{
				NotFound();
			}

			return Ok(Mapper.Map<Customer, CustomerDtos>(customer));
		}

		//POST /api/customers
		[HttpPost]
		public IHttpActionResult CreateCustomer(CustomerDtos customerDto)
		{
			if(!ModelState.IsValid)
			{
				BadRequest();
			}
			var customer = Mapper.Map<CustomerDtos, Customer>(customerDto);
			applicationDbContext.Customers.Add(customer);
			applicationDbContext.SaveChanges();

			customerDto.Id = customer.Id;

			return Created(new Uri(Request.RequestUri + "/" + customer.Id), customerDto);
		}

		//Put /api/customers/1
		[HttpPut]
		public IHttpActionResult UpdateCustomer(int id, CustomerDtos customerDto)
		{
			if (!ModelState.IsValid)
			{
				BadRequest();
			}

			var customerInDb = applicationDbContext.Customers.SingleOrDefault(c => c.Id == id);

			if (customerInDb == null)
			{
				NotFound();
			}

			Mapper.Map<CustomerDtos, Customer>(customerDto, customerInDb);

			applicationDbContext.SaveChanges();

			return Ok();

		}

		//DELETE /api/customers/1
		[HttpDelete]
		public IHttpActionResult DeleteCustomer(int id)
		{
			var customerInDb = applicationDbContext.Customers.SingleOrDefault(c => c.Id == id);

			if (customerInDb == null)
			{
				NotFound();
			}
			applicationDbContext.Customers.Remove(customerInDb);

			applicationDbContext.SaveChanges();

			return Ok();
		}
    }
}
