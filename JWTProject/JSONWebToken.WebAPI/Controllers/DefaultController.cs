using JSONWebToken.WebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JSONWebToken.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult Index()
        {
            return Ok(CreateToken.TokenCreate());
        }

        [HttpGet("[action]")]
        public IActionResult AdminTokenOlustur()
        {
            return Ok(CreateToken.TokenCreateAdmin());
        }

        [Authorize]
        [HttpGet("[action]")]
        public IActionResult Test123()
        {
            return Ok("Gardaşım hoşgeldin çay may içen mi? Gel hele gel otur 2 on muhabbet edelim.");
        }

        [Authorize(Roles = "root,administrator")]
        [HttpGet("[action]")]
        public IActionResult TestAdmin()
        {
            return Ok("Sevgili yöneticimiz reis efendi hazretleri hoşgeldin çay may içen mi? Gel hele gel otur 2 on muhabbet edelim.");
        }
    }
}