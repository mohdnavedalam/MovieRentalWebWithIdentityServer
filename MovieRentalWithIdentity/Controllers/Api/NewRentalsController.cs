using MovieRentalWithIdentity.Dtos;
using MovieRentalWithIdentity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MovieRentalWithIdentity.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            if (newRental.MovieIDs.Count == 0)
                return BadRequest("No Movie IDs have been given"); // Defensive approach

            // var customer = _context.Customers.Single(c => c.ID == newRental.CustomerID); // Optimistic approach

            var customer = _context.Customers.SingleOrDefault(c => c.ID == newRental.CustomerID); // Defensive approach

            if (customer == null)
                return BadRequest("Invalid Customer ID"); // Defensive approach

            var movies = _context.Movies.Where(m => newRental.MovieIDs.Contains(m.ID)).ToList();

            if (movies.Count != newRental.MovieIDs.Count)
                return BadRequest("One or more MovieIDs are invalid"); // Defensive approach

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie not available"); // Defensive approach

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);                
            }

            _context.SaveChanges();

            return Ok();

        }
    }
}