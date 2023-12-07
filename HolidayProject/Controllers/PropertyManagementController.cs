using Domain.Entities;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HolidayProject.Controllers
{
    public class PropertyManagementController : Controller
    {
        private readonly IPropertiesRepository _propertyRepository;

        public PropertyManagementController(IPropertiesRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        [HttpGet]
        public IActionResult AddProperty()
        {
            return View();

        }
        [HttpPost]
        public IActionResult AddProperty(PropertyDetails propertyDetails)
        {
            if (ModelState.IsValid)
                return BadRequest("Property is not valid");
            if (string.IsNullOrEmpty(propertyDetails.Blurb))
                propertyDetails.Blurb = propertyDetails.Description;
            _propertyRepository.addProperty(propertyDetails);
            ViewBag.Status = true;
            return View("AddProperty", propertyDetails);
        }
    }
}
