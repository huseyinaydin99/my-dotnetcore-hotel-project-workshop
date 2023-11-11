using System.Threading.Tasks;
using AydinHotel.Entity.Concretes;
using AydinHotel.WebUI.DTOs.LoginDTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AydinHotel.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginUserDTO loginUserDto)
        {
            if (ModelState.IsValid)
            {
                var result =
                    await _signInManager.PasswordSignInAsync(loginUserDto.Username, loginUserDto.Password, false,
                        false);
                return result.Succeeded ? RedirectToAction("Index", "Staff") : View();
            }
            return View();
        }
    }
}
