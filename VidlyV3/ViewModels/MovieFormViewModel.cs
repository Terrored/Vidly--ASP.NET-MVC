using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyV3.Models;

namespace VidlyV3.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }

        public Movie Movie { get; set; }
    }
}