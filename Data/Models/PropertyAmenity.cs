using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class PropertyAmenity
    {
        public int PropertyId { get; set; }
        public HolidayProperty Property { get; set; }

        public int AmenityId { get; set; }
        public Amenity Amenity { get; set; }
    }
}
