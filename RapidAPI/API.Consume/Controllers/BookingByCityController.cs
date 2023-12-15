using API.Consume.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace API.Consume.Controllers
{
    public class BookingByCityController : Controller
    {
        public async Task<IActionResult> Index(string cityId)
        {
            if (!string.IsNullOrEmpty(cityId))
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?units=metric&locale=en-gb&checkin_date=2024-03-24&dest_type=city&order_by=popularity&filter_by_currency=EUR&adults_number=2&room_number=1&dest_id=-766079&checkout_date=2024-03-27&include_adjacency=true&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&page_number=0&children_ages=5%2C0&children_number=2"),
                    Headers =
                    {
                        { "X-RapidAPI-Key", "dd3fa5539bmsh3b20c335e1895adp104c66jsn47d0556c5e5e" },
                        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
                    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<BookingApiViewModel>(body);
                    return View(values.results.ToList());
                }
            }
            else
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?units=metric&locale=en-gb&checkin_date=2024-03-24&dest_type=city&order_by=popularity&filter_by_currency=EUR&adults_number=2&room_number=1&dest_id=-766079&checkout_date=2024-03-27&include_adjacency=true&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&page_number=0&children_ages=5%2C0&children_number=2"),
                    Headers =
                    {
                        { "X-RapidAPI-Key", "dd3fa5539bmsh3b20c335e1895adp104c66jsn47d0556c5e5e" },
                        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
                    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<BookingApiViewModel>(body);
                    return View(values.results.ToList());
                }
            }

        }
    }
}
