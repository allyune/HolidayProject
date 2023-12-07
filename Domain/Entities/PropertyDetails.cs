using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PropertyDetails : PropertyListing
    {
        [Required]
        [MaxLength(300)]
        public string Description { get; set; }
        [Required]
        public List<string> Amenities { get; set; }
        [DisplayName("Booked Dates")]
        public List<DateTime>? BookedDates { get; set; }
    }
}
