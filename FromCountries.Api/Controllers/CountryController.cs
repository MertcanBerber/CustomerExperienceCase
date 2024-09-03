using CountryApi.Core.Interfaces;
using CountryApi.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CountryApi.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCountries()
        {
            var countries = await _countryService.GetAllCountriesAsync();
            Console.WriteLine(countries);
            return Ok(countries);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCountryById(int id)
        {
            var country = await _countryService.GetCountryByIdAsync(id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

       
        [HttpPost]
        public async Task<IActionResult> AddCountry([FromBody] Country country)
        {
            if (country == null)
            {
                return BadRequest("Country object is null.");
            }

            await _countryService.AddCountryAsync(country);
            return CreatedAtAction(nameof(GetCountryById), new { id = country.Id }, country);
        }

    
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCountry(int id, [FromBody] Country country)
        {
            if (country == null || id != country.Id)
            {
                return BadRequest();
            }

            var existingCountry = await _countryService.GetCountryByIdAsync(id);
            if (existingCountry == null)
            {
                return NotFound();
            }

            await _countryService.UpdateCountryAsync(country);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            var existingCountry = await _countryService.GetCountryByIdAsync(id);
            if (existingCountry == null)
            {
                return NotFound();
            }

            await _countryService.DeleteCountryAsync(id);
            return NoContent();
        }
    }
}
