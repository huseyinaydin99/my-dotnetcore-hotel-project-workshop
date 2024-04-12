using AydinHotel.WebUI.DTOs.ContactDTOs;
using AydinHotel.WebUI.DTOs.ContactDTOs;
using AydinHotel.WebUI.DTOs.SendMessageDTOs;
using AydinHotel.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AydinHotel.WebUI.Controllers
{
    public class AdminContactController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public AdminContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Inbox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:21023/api/Contact");

            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("http://localhost:21023/api/Contact/GetContactCount");

            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("http://localhost:21023/api/SendMessage/GetSendMessageCount");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<InboxContactDTO>>(jsonData);
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                ViewBag.ContactCount = jsonData2;
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                ViewBag.SendMessageCount = jsonData3;
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> Sendbox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:21023/api/SendMessage");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSendboxDTO>>(jsonData);
                return View(values);
            }

            return View();
        }

        [HttpGet]
        public IActionResult AddSendMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSendMessage(CreateSendMessageDTO createSendMessage)
        {
            createSendMessage.SenderMail = "admin@gmail.com";
            createSendMessage.SenderName = "admin";
            createSendMessage.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createSendMessage);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:21023/api/SendMessage", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("SendBox");
            }
            return View();
        }

        public async Task<PartialViewResult> SideBarAdminContactPartial()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:21023/api/GetContactCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                ViewBag.ContactCount = jsonData;
            }
            return PartialView();
        }

        public PartialViewResult SideBarAdminContactCategoryPartial()
        {
            return PartialView();
        }

        public async Task<IActionResult> MessageDetailsBySendbox(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:21023/api/SendMessage/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetMessageByIdDTO>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> MessageDetailsByInbox(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:21023/api/Contact/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<InboxContactDTO>(jsonData);
                return View(values);
            }
            return View();
        }
        /*
        [HttpGet]
        public async Task<IActionResult> GetContactCount()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:21023/api/GetContactCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<InboxContactDTO>>(jsonData);
                return View(values);
            }

            return View();
        }*/
    }
}