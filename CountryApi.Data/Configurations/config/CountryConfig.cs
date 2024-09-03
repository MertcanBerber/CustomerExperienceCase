using CountryApi.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CountryApi.Data.Concrete.EfCore.Configs
{
    public class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(x => x.Region)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Population)
                .IsRequired();

            builder.Property(x => x.Area)
                .IsRequired()
                .HasMaxLength(20); 

            builder.Property(x => x.CreatedDate)
                .IsRequired();

            builder.Property(x => x.ModifiedDate)
                .IsRequired();

            builder.Property(x => x.IsActive)
                .IsRequired();

            builder.Property(x => x.IsDeleted)
                .IsRequired();

            builder.HasData(
                new Country { Id = 1, Name = "Türkiye", Code = "TR", Region = "Avrupa", Population = 86968712, Area = "783562", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 2, Name = "Almanya", Code = "DE", Region = "Avrupa", Population = 83783942, Area = "357022", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 3, Name = "Fransa", Code = "FR", Region = "Avrupa", Population = 65273511, Area = "551695", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 4, Name = "İtalya", Code = "IT", Region = "Avrupa", Population = 60244639, Area = "301340", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 5, Name = "İspanya", Code = "ES", Region = "Avrupa", Population = 46754778, Area = "505992", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 6, Name = "Portekiz", Code = "PT", Region = "Avrupa", Population = 10196709, Area = "92212", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 7, Name = "Hollanda", Code = "NL", Region = "Avrupa", Population = 17134872, Area = "41850", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 8, Name = "Belçika", Code = "BE", Region = "Avrupa", Population = 11589623, Area = "30528", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 9, Name = "Yunanistan", Code = "GR", Region = "Avrupa", Population = 10423054, Area = "131957", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 10, Name = "Avusturya", Code = "AT", Region = "Avrupa", Population = 8917205, Area = "83879", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 11, Name = "Rusya", Code = "RU", Region = "Avrupa", Population = 145912025, Area = "17098242", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 12, Name = "Çin", Code = "CN", Region = "Asya", Population = 1393409038, Area = "9596961", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 13, Name = "Japonya", Code = "JP", Region = "Asya", Population = 126476461, Area = "377975", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 14, Name = "Hindistan", Code = "IN", Region = "Asya", Population = 1366417754, Area = "3287263", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 15, Name = "Güney Kore", Code = "KR", Region = "Asya", Population = 51269185, Area = "100032", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 16, Name = "Endonezya", Code = "ID", Region = "Asya", Population = 273523615, Area = "1904569", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 17, Name = "Brezilya", Code = "BR", Region = "Güney Amerika", Population = 212559417, Area = "8515767", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 18, Name = "Arjantin", Code = "AR", Region = "Güney Amerika", Population = 45195777, Area = "2780400", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 19, Name = "Şili", Code = "CL", Region = "Güney Amerika", Population = 19116209, Area = "756102", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 20, Name = "Kolombiya", Code = "CO", Region = "Güney Amerika", Population = 50882891, Area = "1141748", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 21, Name = "Kanada", Code = "CA", Region = "Kuzey Amerika", Population = 37742154, Area = "9976140", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 22, Name = "Meksika", Code = "MX", Region = "Kuzey Amerika", Population = 128932753, Area = "1964375", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 23, Name = "ABD", Code = "US", Region = "Kuzey Amerika", Population = 331002651, Area = "9372610", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 24, Name = "Avustralya", Code = "AU", Region = "Okyanusya", Population = 25499884, Area = "7692024", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false },
                new Country { Id = 25, Name = "Yeni Zelanda", Code = "NZ", Region = "Okyanusya", Population = 4822233, Area = "268021", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true, IsDeleted = false }
            );
        }
    }
}
