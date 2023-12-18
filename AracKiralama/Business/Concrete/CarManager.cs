using AracKiralama.Business.Abstract;
using AracKiralama.DataAccess.Abstract;
using AracKiralama.Models.Entities;

namespace AracKiralama.Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car t)
        {
            _carDal.Add(t);
        }

        public void Delete(Car t)
        {
            _carDal.Delete(t);
        }

        public Car Get(int id)
        {
           return _carDal.Get(id);
        }

        public List<Car> List()
        {
            return _carDal.List();
        }

        public List<Car> ListTrueCars()
        {
            return _carDal.ListTrueCars();
        }

        public List<Car> ListWith()
        {
            return _carDal.ListWith();
        }

        public void Update(Car t)
        {
            _carDal.Update(t);
        }
    }
}
