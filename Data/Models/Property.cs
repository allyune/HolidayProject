using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Property
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Blurb { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public int NumberOfBedrooms { get; set; }
        [Required]
        public decimal CostPerNight { get; set; }
        [Required]
        [MaxLength(300)]
        public string Description { get; set; }
        [Required]
        public List<string> Amenities { get; set; }
        public List<DateTime>? BookedDates { get; set; }
    }
}
