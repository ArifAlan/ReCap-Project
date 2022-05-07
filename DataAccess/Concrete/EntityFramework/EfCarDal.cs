using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarDBContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailsByCarId(int carId)
        {
            using (RentACarDBContext context = new RentACarDBContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             where c.Id == carId
                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,

                                 DailyPrice = c.DailyPrice,
                                 BrandId = b.BrandId,
                                 ModelName = c.ModelName,
                                 ColorId = co.ColorId,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear,
                                 ImagePath = (from m in context.CarImages where m.CarId == c.Id select m.ImagePath).FirstOrDefault()
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarDBContext context = new RentACarDBContext())
            {
                var result = from car in context.Cars
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId



                             select new CarDetailDto
                             {
                                 //CarName = car.ModelName,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice
                             };

                return result.ToList();
            }
        }
        public List<CarDetailDto> GetCarDetailsByBrandId(int brandId)
        {
            using (RentACarDBContext context = new RentACarDBContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             where b.BrandId == brandId
                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 BrandId = b.BrandId,
                                 ModelName = c.ModelName,
                                 ColorId = co.ColorId,
                                 Description = c.Description,
                                 ImagePath = (from m in context.CarImages where m.CarId == c.Id select m.ImagePath).FirstOrDefault()
                             };
                return result.ToList();
            }
        }



    }
}
