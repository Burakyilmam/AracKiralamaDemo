using AracKiralama.DataAccess.Abstract;
using AracKiralama.Models;
using AracKiralama.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AracKiralama.DataAccess.Repositories
{
    public class CarRepository : GenericRepository<Car> , ICarDal
    {
        private readonly Context _context;

        public CarRepository(Context context) : base(context)
        {
            _context = context;
        }
        public List<Car> ListTrueCars()
        {
            return _context.Cars.Where(x=>x.Statu == true).ToList();
        }
        public List<Car> ListWith()
        {
            return _context.Cars.Include(x=>x.Model).Include(x=>x.Brand).Where(x => x.Statu == true).ToList();
        }
    }
}
