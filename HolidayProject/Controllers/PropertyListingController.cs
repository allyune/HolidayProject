using Microsoft.AspNetCore.Mvc;
using Domain.Repositories;

namespace HolidayProject.Controllers
{
    public class PropertyListingController : Controller
    {
        private readonly IPropertiesRepository _propertyRepository;

        public PropertyListingController(IPropertiesRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        public IActionResult ListAll()
        {
            return View("ListProperties", _propertyRepository.GetAll());
        }

        public IActionResult ListAvailable(DateTime from, DateTime to)
        {
            var availableProperties = _propertyRepository.ListAvailable(from, to);
            return View("ListProperties", availableProperties);
        }

        public IActionResult ViewPropertyDetails(int id)
        {
            var property = _propertyRepository.GetById(id);
            return View("PropertyDetails", property);
        }
    }
}
