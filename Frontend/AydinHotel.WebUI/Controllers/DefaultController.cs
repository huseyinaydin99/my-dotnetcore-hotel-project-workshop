using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using AydinHotel.WebUI.DTOs.SubscribeDTOs;
using AydinHotel.WebUI.DTOs.RoomDTOs;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Authorization;

namespace AydinHotel.WebUI.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult _SubscribePartial()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> _SubscribePartial(CreateSubscribeDTO createSubscribeDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createSubscribeDto);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:21023/api/Subscribe", content);
            /*if (responseMessage.IsSuccessStatusCode)
            {*/
                return RedirectToAction("Index");
            /*}
            return View();*/
        }
    }
}