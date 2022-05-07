using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{ Id=1, BrandId=1, ColorId=2, ModelYear=2014,ModelName="BMW", DailyPrice=150000, Description="Öğretmenden satılık 1.2 motor"},
                new Car{ Id=2, BrandId=2, ColorId=1, ModelYear=2015,ModelName="Mercedes", DailyPrice=180000, Description="Drift arabası 1.6 motor"},
                new Car{ Id=3, BrandId=2, ColorId=1, ModelYear=2016,ModelName="Volkswagen", DailyPrice=190000, Description="Aşiret kasa passat 2.0 motor"},
                new Car{ Id=4, BrandId=1, ColorId=2, ModelYear=2017,ModelName="Renault", DailyPrice=210000, Description="Aile arabası 1.2 motor"},
                new Car{ Id=5, BrandId=2, ColorId=1, ModelYear=2018,ModelName="Audi", DailyPrice=250000, Description="Son model 1800 beygir 9.0 motor"}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
           
            
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsByCarId(int carId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
