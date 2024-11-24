using CarWorkShop.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkShop.Infrastructure.Seeders
{
    public class CarWorkshopSeeder
    {
        private readonly CarWorkShopDbContext _dbContext;

        public CarWorkshopSeeder(CarWorkShopDbContext dbContext)
        {
            _dbContext = dbContext;


        }

        public async Task Seed()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.CarWorkShops.Any())
                {
                    var mazdaAso = new Domain.Entities.CarWorkShop()
                    {
                        Name = "Mazda ASO Test",
                        Description = "Autoryzowsany serwis Mazda",
                        About ="About sekcja",
                        ContactDetails = new()
                        {
                            City = "Kraków",
                            Street = "Szewska 2",
                            PostalCode = "30-001",
                            phoneNumber = "123456789"

                        }
                        
                    };
                    mazdaAso.EncodeName();
                    _dbContext.CarWorkShops.Add(mazdaAso);
                    await _dbContext.SaveChangesAsync();
                }
            }

        }
    }
}
