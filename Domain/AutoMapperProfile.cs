using AutoMapper;
using Data.Models;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Property, PropertyDetails>();
            CreateMap<PropertyDetails, Property>();
        }
    }
}
