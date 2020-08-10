using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AudMovie.Models
{
	public class MyDbContext : DbContext
	{
		public DbSet<Customer> Customers { get; set; }

		public DbSet<Movie> Movies { get; set; }

		public DbSet<MembershipType> MembershipTypes { get; set; }
	}
}