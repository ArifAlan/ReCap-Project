using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //CarManager carManager = new CarManager(new EfCarDal());

            //Car car1 = new Car();
            //car1.BrandId = 1;
            //car1.ColorId = 1;
            //car1.DailyPrice = 800;
            //car1.Description = "Uygun";
            //car1.ModelName = "X50";
            //car1.ModelYear = 2021;



            //carManager.Add(car1);

            //foreach (var item in carManager.GetAll().Data)
            //{
            //    Console.WriteLine("brnad ıd: "+item.BrandId+" "+item.ColorId+" "+item.DailyPrice+" "+item.Description,item.ModelName);
            //    Console.WriteLine("-----------------");
            //}

            //ColorManager colorManager = new ColorManager(new EfColorDal());

            //Color color1 = new Color();
            //color1.ColorName = "SİYAH";
            //color1.ColorId = 3;
            //Color color = new Color();
            //color.ColorName = "Gri";
            //color.ColorId = 1005;

            ////colorManager.Delete(color);
               


            ////colorManager.Delete(color1);

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //Brand brand1 = new Brand();
            ////brand1.BrandName = "Audi";
            //brand1.BrandId = 9;

            ////brandManager.Delete(brand1);

            //Car car2 = new Car();
            //car2.Id = 4;
            //car2.DailyPrice = 550;
            //car2.Description = "Yeni fiyattt.";
            //car2.ModelName = "320İ";
            //car2.ModelYear = 2014;
            //car2.BrandId = 1;
            //car2.ColorId = 1;


            //Car car3 = new Car();
            //car3.Id = 8;
            //car3.BrandId = 1;
            //car3.ColorId = 1;
            //car3.Description = "Drift arabası 1.6 motor";
            //car3.DailyPrice = 110;
            //car3.ModelName = "520";
            //car3.ModelYear = 2015;

            //Car car4 = new Car();
            //car4.Id = 12;
            //car4.BrandId = 2;
            //car4.ColorId = 2;
            //car4.DailyPrice = 150;
            //car4.ModelYear = 2021;
            //car4.ModelName = "Q7";
            //car4.Description = "Son model 1800 beygir 9.0 motor";


            //carManager.Update(car4);
        }
    }
}
