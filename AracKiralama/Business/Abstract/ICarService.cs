using AracKiralama.Models.Entities;

namespace AracKiralama.Business.Abstract
{
    public interface ICarService : IGenericService<Car>
    {
        public List<Car> ListTrueCars();
        public List<Car> ListWith();
    }
}
