using Microsoft.AspNetCore.Mvc;

namespace AydinHotel.WebUI.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
