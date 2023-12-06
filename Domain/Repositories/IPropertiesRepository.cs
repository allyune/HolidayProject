using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IPropertiesRepository
    {
        public List<PropertyDetails> GetAll();
        public List<PropertyDetails> ListAvailable(DateTime dateFrom, DateTime dateTo);
        public PropertyDetails GetById(int id);
    }
}