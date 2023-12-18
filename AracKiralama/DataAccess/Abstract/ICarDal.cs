using AracKiralama.Models.Entities;

namespace AracKiralama.DataAccess.Abstract
{
    public interface ICarDal : IGenericDal<Car>
    {
        List<Car> ListTrueCars();
        List<Car> ListWith();
    }
}
