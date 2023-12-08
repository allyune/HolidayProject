using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class BookedNight
    {
        public int BookedNightId { get; set; }
        public DateTime Night { get; set; }
        public int PropertyId { get; set; }
        public HolidayProperty Property { get; set; }
    }
}
