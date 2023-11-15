using Microsoft.AspNetCore.Mvc;

namespace AydinHotel.WebUI.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
