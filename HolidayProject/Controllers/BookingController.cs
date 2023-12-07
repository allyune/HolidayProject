using Domain.Entities;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace HolidayProject.Controllers
{
    public class BookingController : Controller
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpPost]
        public IActionResult AddBooking(PropertyBooking booking)
        {
            var property = _bookingService.AddBookingDates(booking);
            return View("~/Views/PropertyListing/PropertyDetails.cshtml", property);
        }
    }
}
