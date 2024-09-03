

using CountryApi.Core.Interfaces;
using CountryApi.Entity.Concrete;

public interface ICountryService
{
    Task<IEnumerable<Country>> GetAllCountriesAsync();
    Task<Country> GetCountryByIdAsync(int id);
    Task AddCountryAsync(Country country);
    Task UpdateCountryAsync(Country country);
    Task DeleteCountryAsync(int id);
}

public class CountryService : ICountryService
{
    private readonly ICountryRepository _countryRepository;

    public CountryService(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }

    public async Task<IEnumerable<Country>> GetAllCountriesAsync()
    {
        return await _countryRepository.GetAllCountriesAsync();
    }

    public async Task<Country> GetCountryByIdAsync(int id)
    {
        return await _countryRepository.GetCountryByIdAsync(id);
    }

    public async Task AddCountryAsync(Country country)
    {
        await _countryRepository.AddCountryAsync(country);
    }

    public async Task UpdateCountryAsync(Country country)
    {
        await _countryRepository.UpdateCountryAsync(country);
    }

    public async Task DeleteCountryAsync(int id)
    {
        await _countryRepository.DeleteCountryAsync(id);
    }
}
