using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class PropertyListingService : IPropertyListingService
    {
        private readonly IPropertiesRepository _propertiesRepository;
        private readonly IMapper _mapper;

        public PropertyListingService(IPropertiesRepository propertiesRepository, IMapper mapper)
        {
            _propertiesRepository = propertiesRepository;
            _mapper = mapper;
        }

        public IEnumerable<PropertyDetails> GetAll()
        {
            var properties = _propertiesRepository.GetAll();
            return properties.Select(p => _mapper.Map<PropertyDetails>(p)).ToList();
        }

        public IEnumerable<PropertyDetails> GetAvailable(DateTime from, DateTime to)
        {
            var properties = _propertiesRepository.ListAvailable(from, to);
            return properties.Select(p => _mapper.Map<PropertyDetails>(p)).ToList();
        }
        public PropertyDetails GetPropertyById(int id)
        {
            var property = _propertiesRepository.GetById(id);
            return _mapper.Map<PropertyDetails>(property);
        }
    }
}
