﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PropertyDetails : PropertyListing
    {
        public string Description { get; set; }
        public List<string> Amenities { get; set; }
        public List<DateTime> BookedDates { get; set; }
    }
}
