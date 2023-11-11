using AydinHotel.Entity.Concretes;
using AydinHotel.WebUI.DTOs.RegisterDTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AydinHotel.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CreateNewUserDTO createNewUserDto)
        {
            return View();
        }
    }
}
