using System.Threading.Tasks;
using AutoMapper;
using AydinHotel.Entity.Concretes;
using AydinHotel.WebUI.DTOs.RegisterDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AydinHotel.WebUI.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public RegisterController(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDTO createNewUserDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var appUser = _mapper.Map<AppUser>(createNewUserDto);
            appUser.WorkLocationId = 1;
            var result = await _userManager.CreateAsync(appUser, createNewUserDto.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }
            return View();
        }
    }
}
