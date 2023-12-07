using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PropertyBooking
    {
        public int PropertyId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
