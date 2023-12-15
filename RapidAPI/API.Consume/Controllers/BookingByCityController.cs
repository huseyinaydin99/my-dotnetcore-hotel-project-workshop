using Microsoft.AspNetCore.Mvc;

namespace API.Consume.Controllers
{
    public class BookingByCityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
