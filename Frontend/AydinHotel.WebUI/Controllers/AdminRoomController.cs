using AydinHotel.WebUI.DTOs.RoomDTOs;
using AydinHotel.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AydinHotel.WebUI.Controllers
{
    public class AdminRoomController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminRoomController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:21023/api/Room");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultRoomDTO>>(jsonData);
                return View(values);
            }

            return View();
        }

        [HttpGet]
        public IActionResult AddRoom()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRoom(CreateRoomDTO createRoomDTO)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createRoomDTO);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:21023/api/Room", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:21023/api/Room/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return await Index();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateRoom(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:21023/api/Room/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateRoomDTO>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRoom(UpdateRoomDTO updateRoomDTO, int id)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateRoomDTO);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:21023/api/Room", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
