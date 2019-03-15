using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
	public class MoviesController : Controller
	{
		// this will be called when we go to  GET: Movies/Random
		public ActionResult Random() // you use the action result so you can use any of its subtypes
		{

			var movie = new Movie()
			{
				Name = "Shrek!"
			};

			//return Content("Hello World");
			//return HttpNotFound(); // displays standard 404 error
			//return new EmptyResult();
			//return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});
			//return new ViewResult();
			return View(movie); // add movie model to render it  


		}

		public ActionResult Edit(int id)
		{
			return Content("id =  " + id);
		}

		// movies
		// this action should return a view with a list of movies in the dataBase
		public ActionResult Index(int? pageIndex, string sortBy) // question  mark makes it nullable 
		{
			// inside the action check to see if the parameters have a value
			if (!pageIndex.HasValue)
				pageIndex = 1;
			
			if (String.IsNullOrWhiteSpace(sortBy))
			sortBy = "Name";

			return Content(String.Format("pageIndex = {0} & sortBy = {1}",pageIndex, sortBy));
		}
		
	}
}

