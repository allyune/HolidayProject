using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PropertyListing
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
    }
}
