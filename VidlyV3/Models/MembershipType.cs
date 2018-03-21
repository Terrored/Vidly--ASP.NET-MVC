﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidlyV3.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }    
        public short SignedUpFee { get; set; } 
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}