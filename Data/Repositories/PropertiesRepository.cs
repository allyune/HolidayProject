using Data.Models;
using Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class PropertiesRepository : IPropertiesRepository
    {
        private List<Property> _properties = PropertiesData.Properties;
        public List<Property> GetAll()
        {
            return _properties;
        }

        public List<Property> ListAvailable(DateTime dateFrom, DateTime dateTo)
        {
            var properties = _properties
                .Where(p => PropertiesUtils.isAvailableForPeriod(dateFrom, dateTo, p.BookedDates))
                .ToList();
            return properties;
        }

        public Property GetById(int id)
        {
            var property = _properties.FirstOrDefault(p => p.Id == id);
            if (property == null)
                throw new ArgumentNullException("id");
            return property;
        }

        public void addProperty(Property propertyDetails)
        {
            _properties.Add(propertyDetails);
        }
    }
}
