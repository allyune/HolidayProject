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

        public IActionResult ListProperties()
        {
            return View(_propertyRepository.GetAll());
        }
    }
}
