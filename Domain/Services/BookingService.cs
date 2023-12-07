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
    public class BookingService : IBookingService
    {
        private readonly IPropertiesRepository _propertiesRepository;
        private readonly IMapper _mapper;

        public BookingService(IPropertiesRepository propertiesRepository, IMapper mapper)
        {
            _propertiesRepository = propertiesRepository;
            _mapper = mapper;
        }
        public PropertyDetails AddBookingDates(PropertyBooking booking)
        {
            if (booking.From.Date >= booking.To.Date)
                throw new ArgumentException("Wrong dates");
            List<DateTime> dates = new List<DateTime>();
            for (DateTime date = booking.From.Date; date <= booking.To.Date; date = date.AddDays(1))
            {
                dates.Add(date);
            }
            try
            {
                var property = _propertiesRepository.AddBookingDates(booking.PropertyId, dates);
                return _mapper.Map<PropertyDetails>(property);
            }
            catch (Exception) { throw;  }
        }
    }
}
