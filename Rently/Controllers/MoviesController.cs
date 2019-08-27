using Rently.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Rently.ViewModels;

namespace Rently.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{Id =1, Name = "Shrek"},
                new Movie{Id = 2, Name = "Cars"},
                new Movie{Id = 3, Name = "Family Guy"},
            };
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movies = new List<Movie>
            {
               new Movie{ Name = "Shrek"},
               new Movie{ Name = "Cars"},
               new Movie{ Name = "Family Guy"},
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movies = movies,
            };

            // ViewData["Movie"] = movie;
            //var viewResult = new ViewResult();
            // viewResult.ViewData.Model

            return View(viewModel);

        }
        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}
        //// movies

        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
    }
}