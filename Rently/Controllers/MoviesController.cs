﻿using Rently.Models;
using System;
using System.Linq;
using System.Web.Mvc;
using Rently.ViewModels;
using System.Data.Entity;

namespace Rently.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        [Authorize(Roles = RoleName.Admin)]
        public ActionResult New()
        {
            var listOfGenreType = _context.GenreTypes.ToList();

            var viewModel = new MovieFormViewModel
            {

                GenreTypes = listOfGenreType
            };

            return View("MovieForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel(movie)
            {
                
                GenreTypes = _context.GenreTypes.ToList()
            };

            return View("MovieForm", viewModel);
        }
        public ViewResult Index()
        {
            if (User.IsInRole(RoleName.Admin))
            {
                return View("List");
            }

            return View("ReadOnlyList");
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {
                  
                    GenreTypes = _context.GenreTypes.ToList()

                };
                return View("MovieForm", viewModel);
            }
            if (movie.Id == 0)

            {

                movie.DateAdded = DateTime.Now;

                _context.Movies.Add(movie);

            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;

                movieInDb.GenreTypeId = movie.GenreTypeId;

                movieInDb.NumberInStock = movie.NumberInStock;

                movieInDb.ReleaseDate = movie.ReleaseDate;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }


    }


}