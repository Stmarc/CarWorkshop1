using CarWorkShop.Domain.Interfaces;
using CarWorkShop.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkShop.Infrastructure.Repository
{
    internal class CarWorkshopRepository : ICarWorkShopRepository
    {
        private CarWorkShopDbContext _dbContext;

        public CarWorkshopRepository(CarWorkShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Create(Domain.Entities.CarWorkShop carWorkShop)
        {
            _dbContext.Add(carWorkShop);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Domain.Entities.CarWorkShop>> GetAll()
       => await _dbContext.CarWorkShops.ToListAsync();


        public  Task<Domain.Entities.CarWorkShop> GetOne(string name)
        => _dbContext.CarWorkShops.FirstOrDefaultAsync(cw => cw.Name.ToLower() == name.ToLower());


        public Task<Domain.Entities.CarWorkShop> GetByName(string name)
        =>_dbContext.CarWorkShops.FirstOrDefaultAsync(cw => cw.Name.ToLower() == name.ToLower());


        public Task<Domain.Entities.CarWorkShop> GetByEncodedName(string encodedName)
         => _dbContext.CarWorkShops.FirstAsync(cw => cw.EncodedName == encodedName);

    }


}
