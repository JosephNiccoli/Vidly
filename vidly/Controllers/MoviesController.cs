using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace vidly.Controllers
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
    }
}