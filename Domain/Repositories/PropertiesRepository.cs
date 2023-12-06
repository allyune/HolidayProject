using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class PropertiesRepository : IPropertiesRepository
    {
        private readonly List<PropertyDetails> _propertiesListing = PropertiesData.Properties;
        public List<PropertyDetails> GetAll()
        {
            return _propertiesListing;
        }

        public List<PropertyDetails> ListAvailable(DateTime dateFrom, DateTime dateTo)
        {
            throw new NotImplementedException();
        }

        public PropertyDetails GetById(int id)
        {
            var property = _propertiesListing.FirstOrDefault(p => p.Id == id);
            if (property == null)
                throw new ArgumentNullException("id");
            return property;
        }
    }
}
