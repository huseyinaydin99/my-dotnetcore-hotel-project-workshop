using Microsoft.AspNetCore.Mvc;

namespace AydinHotel.WebUI.ViewComponent.Booking
{
    public class _BookingCoverPartial : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
