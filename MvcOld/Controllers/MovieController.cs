using MvcOld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOld.Controllers
{
    public class MovieController : Controller
    {
        
        public static List<Movie> movies = new List<Movie>();
        // GET: Products
        [Route("/GetAllMovies")]
        [HttpGet]
        public ActionResult GetAllMovies()
        {
            if (movies.Count == 0)
            {
                movies.Add(new Movie() { MovieName = "KGF 2", Ratings = 4.9, id = 1001 });
            }
            return View(movies);
        }

        [HttpGet]
        public ActionResult AddMovie()
        {
            return View(new Movie());
        }


        [HttpPost]
        public ActionResult AddMovie(Movie mMovie)
        {
            movies.Add(mMovie);
            return View("GetAllMovies", movies);
        }

        [HttpGet]
        public ActionResult AddAjaxMovie()
        {
            return View(new Movie());
        }

        [HttpPost]
        public ActionResult AddAjaxMovie(Movie mMovie)
        {
            movies.Add(mMovie);
            return PartialView("GetAllMovies", movies);
        }

        [HttpGet]
        public ActionResult Edit(string movieName)
        {
            Movie found = movies.Where(single => single.MovieName == movieName).ToList().FirstOrDefault();
            return View(found);
        }
        [HttpPost]
        public ActionResult Edit(Movie updatedRating)
        {
            Movie found = movies.Where(single => single.MovieName == updatedRating.MovieName).ToList().FirstOrDefault();
            found.MovieName = updatedRating.MovieName;
            found.Ratings = updatedRating.Ratings;
            found.id=updatedRating.id; 
            return View("GetAllMovies", movies);
        }

        [HttpGet]
        public ActionResult Delete(string movieName)
        {
            Movie found = movies.Where(single => single.MovieName == movieName).ToList().FirstOrDefault();
            return View(found);
        }
        [HttpPost]
        public ActionResult Delete(Movie mMovie)
        {
            Movie found = movies.Where(single => single.MovieName == mMovie.MovieName).ToList().FirstOrDefault();
            movies.Remove(found);
            return View("GetAllMovies", movies);
        }

    }
}