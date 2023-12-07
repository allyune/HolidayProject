using Domain.Entities;
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
        private List<PropertyDetails> _properties = PropertiesData.Properties;
        public List<PropertyDetails> GetAll()
        {
            return _properties;
        }

        public List<PropertyDetails> ListAvailable(DateTime dateFrom, DateTime dateTo)
        {
            var properties = _properties
                .Where(p => PropertiesUtils.isAvailableForPeriod(dateFrom, dateTo, p.BookedDates))
                .ToList();
            return properties;
        }

        public PropertyDetails GetById(int id)
        {
            var property = _properties.FirstOrDefault(p => p.Id == id);
            if (property == null)
                throw new ArgumentNullException("id");
            return property;
        }

        public void addProperty(PropertyDetails propertyDetails)
        {
            _properties.Add(propertyDetails);
        }
    }
}
