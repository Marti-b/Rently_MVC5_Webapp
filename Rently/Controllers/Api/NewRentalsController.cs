using AutoMapper;
using Rently.Dtos;
using Rently.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Rently.Controllers.Api
{
   
    public class NewRentalsController:ApiController
    {
        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        private ApplicationDbContext _context;

        [HttpPost]
        public IHttpActionResult CreateNewRentals (NewRentaDto newRental)
        {
            var customer = _context.Customers.SingleOrDefault(
                c => c.Id == newRental.CustomerId);

            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                {
                    return BadRequest("Movie is not available");
                }

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