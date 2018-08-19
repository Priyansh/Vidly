using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMVC.Models;
using VidlyMVC.ViewModels;

namespace VidlyMVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var myMovie = new Movie() { Name = "Shark Tank" };

            var myCustomers = new List<Customer>
            {
                new Customer { Name = "Customer1" },
                new Customer { Name = "Customer2" }
            };
            var randomMovieViewModel = new RandomMovieViewModel
            {
                movieName = myMovie,
                lstCustomers = myCustomers
            };
            return View(randomMovieViewModel);
        }

        [Route("movies/releasedate/{month:regex(\\d{2}):range(1,12)}/{year:regex(\\d{4})}")]
        public ActionResult ByReleaseDate(int month, int year)
        {
            return Content(month + "/" + year);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        public ActionResult Index(int? pageIndex, String sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            else if (string.IsNullOrEmpty(sortBy))
                sortBy = "Name";
            return Content(string.Format("PageIndex = {0}, SortBy = {1}", pageIndex, sortBy));
        }
    }
}