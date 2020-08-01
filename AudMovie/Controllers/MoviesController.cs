using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AudMovie.Models;

namespace AudMovie.Controllers
{
    public class MoviesController : Controller
    {
		//private MyDbContext myDbContext;
		// GET: Movies
		public ActionResult Index()
		{
			var movie = new List<Movie>
			{
				new Movie
				{
					Id = 1, Name = "Shrek"
				},
				new  Movie
				{
					Id = 2, Name = "Princess"
				}
			};
			return View(movie);
		}

		public ActionResult Details(int id)
		{
			var movie = new List<Movie>
			{
				new Movie
				{
					Id = 1, Name = "Shrek"
				},
				new Movie
				{
					Id = 2, Name = "Princess"
				}
			}.SingleOrDefault(c => c.Id == id);
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