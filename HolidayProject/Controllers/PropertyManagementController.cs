using Domain.Entities;
using Domain.Repositories;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace HolidayProject.Controllers
{
    public class PropertyManagementController : Controller
    {
        private readonly IPropertyManagementService _managementService;

        public PropertyManagementController(IPropertyManagementService managementService)
        {
            _managementService = managementService;
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
            _managementService.AddProperty(propertyDetails);
            ViewBag.Status = true;
            return View("AddProperty", propertyDetails);
        }
    }
}
