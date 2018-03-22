using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyV3.Models;

namespace VidlyV3.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }


    }
}