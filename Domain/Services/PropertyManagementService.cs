using AutoMapper;
using Data.Models;
using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class PropertyManagementService : IPropertyManagementService
    {
        private readonly IPropertiesRepository _propertiesRepository;
        private readonly IMapper _mapper;

        public PropertyManagementService(IPropertiesRepository propertiesRepository, IMapper mapper)
        {
            _propertiesRepository = propertiesRepository;
            _mapper = mapper;
        }

        public void AddProperty(PropertyDetails propertyDetails)
        {
            var propertyModel = _mapper.Map<Property>(propertyDetails);
            _propertiesRepository.addProperty(propertyModel);
        }
    }
}
