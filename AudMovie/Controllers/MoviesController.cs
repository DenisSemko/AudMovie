using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AudMovie.Models;
using System.Data.Entity;

namespace AudMovie.Controllers
{
    public class MoviesController : Controller
    {
		private MyDbContext myDbContext;
		public MoviesController()
		{
			myDbContext = new MyDbContext();
		}
		protected override void Dispose(bool disposing)
		{
			myDbContext.Dispose();
		}
		// GET: Movies
		public ActionResult Index()
		{
			var movie = myDbContext.Movies.Include(m => m.Genre).ToList();
			return View(movie);
		}

		public ActionResult Details(int id)
		{
			var movie = myDbContext.Movies.Include(m => m.Genre).SingleOrDefault(c => c.Id == id);
			return View(movie);
		}
		public ActionResult Edit(int id)
		{
			return Content("ID = " + id);
		}


		[Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
		public ActionResult ByReleaseDate(int year, int month)
		{
			return Content(year + "/" + month);
		}
	}
}