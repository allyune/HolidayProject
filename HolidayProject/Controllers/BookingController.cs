using Domain.Entities;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

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
            try
            {
                var property = _bookingService.AddBookingDates(booking);
                return View("~/Views/PropertyListing/PropertyDetails.cshtml", property);
            }
            catch (ArgumentException ex)
            {
                return BadRequest("Wrong dates");
            }
            catch (NullReferenceException)
            {
                return BadRequest("Property does not exist");
            }
            catch (IndexOutOfRangeException)
            {
                return BadRequest("Property is not available for this period");
            }
            catch (Exception ex)
            {
                // SHould have proper logging
                Console.WriteLine(ex.Message);
                return BadRequest("Booking error, try again");
            }
        }
    }
}
