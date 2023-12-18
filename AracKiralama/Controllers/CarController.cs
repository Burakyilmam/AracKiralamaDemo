using AracKiralama.Business.Abstract;
using AracKiralama.Business.Concrete;
using AracKiralama.DataAccess.Abstract;
using AracKiralama.DataAccess.Repositories;
using AracKiralama.Models;
using AracKiralama.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AracKiralama.Controllers
{
    public class CarController : Controller
    {
        // N Tier

        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        public IActionResult CarList()
        {
            var value = _carService.ListWith();
            return View(value);
        }
        [HttpGet]
        public IActionResult CarAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CarAdd(Car car)
        {
            car.Statu = true;
            car.CreateDate = DateTime.UtcNow;
            _carService.Add(car);
            return RedirectToAction("CarList");
        }
        public IActionResult CarDelete(int id)
        {
            var value = _carService.Get(id);
            _carService.Delete(value);
            return RedirectToAction("CarList");
        }
        [HttpGet]
        public IActionResult EditCar(int id)
        {
            var value = _carService.Get(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditCar(Car car)
        {
            car.CreateDate = DateTime.SpecifyKind(car.CreateDate, DateTimeKind.Unspecified);
            car.CreateDate = TimeZoneInfo.ConvertTimeToUtc(car.CreateDate, TimeZoneInfo.Utc);
            _carService.Update(car);
            return RedirectToAction("CarList");
        }

        // Repository Pattern
        //private readonly ICarDal _carDal;

        //public CarController(ICarDal carDal)
        //{
        //    _carDal = carDal;
        //}
        //public IActionResult CarList()
        //{
        //    var value = _carDal.ListWith();
        //    return View(value);
        //}
        //[HttpGet]
        //public IActionResult CarAdd()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult CarAdd(Car car)
        //{
        //    car.Statu = true;
        //    car.CreateDate = DateTime.UtcNow;
        //    _carDal.Add(car);
        //    return RedirectToAction("CarList");
        //}
        //public IActionResult CarDelete(int id)
        //{
        //    var value = _carDal.Get(id);
        //    _carDal.Delete(value);
        //    return RedirectToAction("CarList");
        //}
        //[HttpGet]
        //public IActionResult EditCar(int id)
        //{
        //    var value = _carDal.Get(id);
        //    return View(value);
        //}
        //[HttpPost]
        //public IActionResult EditCar(Car car)
        //{
        //    car.CreateDate = DateTime.SpecifyKind(car.CreateDate, DateTimeKind.Unspecified);
        //    car.CreateDate = TimeZoneInfo.ConvertTimeToUtc(car.CreateDate, TimeZoneInfo.Utc);
        //    _carDal.Update(car);
        //    return RedirectToAction("CarList");
        //}       
    }
}
