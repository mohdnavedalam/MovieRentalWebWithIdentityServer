using MovieRentalWithIdentity.Models;
using MovieRentalWithIdentity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRentalWithIdentity.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie> 
            {
                new Movie {ID = 1, Name = "Ironman"},
                new Movie { ID = 2, Name = "Ironman 2"}
            };
        }

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Ironman" };
            var customer = new List<Customer>
            {
                new Customer { Name = "Naved" },
                new Customer { Name = "Apun" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customer
            };

            return View(viewModel);
        }

        public ActionResult Edit(int ID)
        {
            // return View();
            return Content("ID = " + ID);
        }

        [Route("movie/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            // return View();
            return Content(year + "/" + month);
        }
    }
}