using Microsoft.AspNetCore.Mvc;
using Domain.Repositories;
using Domain.Services;

namespace HolidayProject.Controllers
{
    public class PropertyListingController : Controller
    {
        private readonly IPropertyListingService _listingService;

        public PropertyListingController(IPropertyListingService listingService)
        {
            _listingService = listingService;
        }

        public IActionResult ListAll()
        {
            return View("ListProperties", _listingService.GetAll());
        }

        public IActionResult ListAvailable(DateTime from, DateTime to)
        {
            var availableProperties = _listingService.GetAvailable(from, to);
            return View("ListProperties", availableProperties);
        }

        public IActionResult ViewPropertyDetails(int id)
        {
            ViewBag.BookingMessage = null;
            var property = _listingService.GetPropertyById(id);
            return View("PropertyDetails", property);
        }
    }
}
