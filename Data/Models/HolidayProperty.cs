using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class HolidayProperty
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Blurb { get; set; }
        public string Location { get; set; }
        public int NumberOfBedrooms { get; set; }
        public decimal CostPerNight { get; set; }
        public string Description { get; set; }
        public ICollection<PropertyAmenity> PropertyAmenities { get; set; }
        public List<BookedNight>? BookedDates { get; set; }
    }
}
