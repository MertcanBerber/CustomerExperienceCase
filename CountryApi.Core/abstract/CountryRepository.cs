using System.Collections.Generic;
using System.Threading.Tasks;
using CountryApi.Entity.Concrete;

namespace CountryApi.Core.Interfaces
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> GetAllCountriesAsync();
        Task<Country> GetCountryByIdAsync(int id);
        Task AddCountryAsync(Country country);
        Task UpdateCountryAsync(Country country);
        Task DeleteCountryAsync(int id);
    }
}
