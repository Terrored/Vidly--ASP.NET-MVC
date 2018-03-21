using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using VidlyV3.Models;
using VidlyV3.ViewModels;

namespace VidlyV3.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        
        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie
                {
                    Id=1,
                    Name="Star Wars"
                },
                new Movie
                {
                    Id=2,
                    Name="Spiderman"
                }
            };
        }





        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie(){Name = "Shrek!"};

            //var viewResult = new ViewResult();

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            

            return View(viewModel);
           // return Content("Hello World!");
            //return HttpNotFound();
        }

        //[Route("movies/released/{year}/{month}")]
       public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }
        //movies
        //public ActionResult Index(int? pageIndex,string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}
    }
}