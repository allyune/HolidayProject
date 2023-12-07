using Microsoft.AspNetCore.Mvc;

namespace HolidayProject.Components
{
    public class FindPropertyViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
