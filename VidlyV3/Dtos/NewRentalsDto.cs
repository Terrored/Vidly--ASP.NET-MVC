using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidlyV3.Dtos
{
    public class NewRentalsDto
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}