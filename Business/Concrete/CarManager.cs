using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.BusinessAspects.Autofac;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IBrandService _brandService;

        public CarManager(ICarDal carDal, IBrandService brandService)
        {
            _carDal = carDal;
            _brandService = brandService;
        }
        //[SecuredOperation("admin")] //BURADA NE YAZIYOR car.add,admin BU ŞEKLDEGERİNCE MU MAL VİRGÜLÜ ALGILAMIYOR KOMPLE BUNU TEK BİR YETKİ SANIYOR
        [ValidationAspect(typeof(CarValidator))]  
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {

            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);


        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        [CacheAspect]// key ,value
        //[SecuredOperation("admin")]
       //[PerformanceAspect(5)]
        public IDataResult<List<Car>> GetAll()
        {
            

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);

        }
        public IDataResult<List<Car>> GetCarsById(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.Id == Id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsByCarId(int carId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailsByCarId(carId));
        }
        public IDataResult<List<CarDetailDto>> GetCarDetailsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailsByCarId(brandId));
        }
        [CacheAspect]
        public IDataResult<List<Car>> GetCarsByBrandId(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == Id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == Id));
        }

        public IDataResult<List<Car>> GetCarsByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice <= min && c.DailyPrice <= max));

        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IDataResult<List<Car>> GetCarsByColorIdAndBrandId(int colorId, int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId && c.BrandId==brandId));
        }
    }
}
