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

        public IActionResult ListAvailable()
        {
            return View("ListProperties", _propertyRepository.GetAll());
        }
    }
}
