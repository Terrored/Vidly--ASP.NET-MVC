using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyV3.Models;

namespace VidlyV3.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }

        public List<Customer> Customers { get; set; }
    }
}