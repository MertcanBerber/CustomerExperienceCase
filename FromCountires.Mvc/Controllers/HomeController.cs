using FromRestCountries.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace FromRestCountries.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Root> countryList = new List<Root>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7140/api/Country"))
                {
                    var stringResponse = await response.Content.ReadAsStringAsync();
                    countryList = JsonSerializer.Deserialize<List<Root>>(stringResponse, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
                }
            }

           
            var groupedData = countryList
                .Where(country => !string.IsNullOrEmpty(country.Region)) 
                .GroupBy(country => country.Region)
                .ToDictionary(g => g.Key, g => g.ToList());

           
            ViewData["GroupedCountryData"] = JsonSerializer.Serialize(groupedData, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });

            return View(countryList);
        }
    }
}
