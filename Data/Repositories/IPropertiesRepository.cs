using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IPropertiesRepository
    {
        public List<Property> GetAll();
        public List<Property> ListAvailable(DateTime dateFrom, DateTime dateTo);
        public Property GetById(int id);
        public void addProperty(Property propertyDetails);
    }
}
