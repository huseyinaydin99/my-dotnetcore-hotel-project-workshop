using AydinHotel.WebUI.DTOs.ServiceDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AydinHotel.WebUI.DTOs.AboutDTOs;

namespace AydinHotel.WebUI.ViewComponent.Default
{
    public class _AboutUsPartial : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutUsPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:21023/api/About");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutDTO>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}