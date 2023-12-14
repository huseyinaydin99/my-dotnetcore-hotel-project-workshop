using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AydinHotel.WebUI.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult AddBooking()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> AddBooking(string x)
        {
            return View();
        }
    }
}
