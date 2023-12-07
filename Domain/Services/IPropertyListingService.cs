using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IPropertyListingService
    {
       public PropertyDetails GetPropertyById(int id);
        public IEnumerable<PropertyDetails> GetAll();
        public IEnumerable<PropertyDetails> GetAvailable(DateTime from, DateTime to);
    }
}
