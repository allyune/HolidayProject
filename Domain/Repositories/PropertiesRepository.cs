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
        private readonly List<PropertyListing> _propertiesListing = PropertiesData.Properties;
        public List<PropertyListing> GetAll()
        {
            return _propertiesListing;
        }

        public List<PropertyListing> ListAvailable(DateTime dateFrom, DateTime dateTo)
        {
            throw new NotImplementedException();
        }
    }
}
