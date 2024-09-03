using System.Collections.Generic;
using System.Threading.Tasks;
using CountryApi.Core.Interfaces;
using CountryApi.Data.Concrete.EfCore;
using CountryApi.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CountryApi.Data.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly CountryContext _context;

        public CountryRepository(CountryContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Country>> GetAllCountriesAsync()
        {
            return await _context.Countries.ToListAsync();
        }

        public async Task<Country> GetCountryByIdAsync(int id)
        {
            return await _context.Countries.FindAsync(id);
        }

        public async Task AddCountryAsync(Country country)
        {
            _context.Countries.Add(country);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCountryAsync(Country country)
        {
            _context.Countries.Update(country);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCountryAsync(int id)
        {
            var country = await _context.Countries.FindAsync(id);
            if (country != null)
            {
                _context.Countries.Remove(country);
                await _context.SaveChangesAsync();
            }
        }
    }
}
