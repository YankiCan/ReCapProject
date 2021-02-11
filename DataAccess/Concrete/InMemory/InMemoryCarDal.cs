using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        private int carId;
        private int brandId;
        private int colorId;

        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            { 
                new Car {CarId=1, BrandId=2, ColorId=5, ModelYear=2015, DailyPrice=80000, Description="Dacia Sandero"},
                new Car {CarId=2, BrandId=4, ColorId=7, ModelYear=2019, DailyPrice=185000, Description="Fiat 500"},
                new Car {CarId=3, BrandId=6, ColorId=9, ModelYear=2021, DailyPrice=220000, Description="Ford Fiesta"},

            };
        }

        public int ColorId { get; private set; }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c => c.CarId == carId && c.BrandId == brandId && c.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => car.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
