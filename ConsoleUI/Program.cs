using Business.Concrete;
using System;
using System.Data;
using System.Linq;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car2 = new Car { CarName = "denemee", BrandId = 2, ColorId = 2, ModelYear = 2020, DailyPrice = 110, Description = "deeeeee" };
            Brand brand2 = new Brand { BrandName = "DENEME" };
            Brand brand3 = new Brand { BrandId = 1002, BrandName = "DENEME123123" };
            Color color2 = new Color { ColorName = "Bordo" };
            //CarTest(car2);
            //BrandTest(brand2);
            //ColorTest(color2);
            //CarDetailDtoTest();
        }

        private static void CarDetailDtoTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.DailyPrice + "/" + car.BrandName + "/" + car.CarName + "/" + car.ColorName);
            }
        }

        private static void ColorTest(Color color2)
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(color2);
            colorManager.Update(new Color { ColorId = 1002, ColorName = "testt" });
            colorManager.Delete(new Color { ColorId = 1002 });
            Console.WriteLine(colorManager.GetById(4).ColorName);
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest(Brand brand2)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(brand2);
            brandManager.Update(new Brand { BrandId = 2003, BrandName = "deneme123123124" });
            brandManager.Delete(new Brand { BrandId = 1002 });
            Console.WriteLine(brandManager.GetById(4).BrandId);
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest(Car car2)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car { CarId = 1004, CarName = "Clio" });
            carManager.Delete(new Car { CarId = 2003 });
            carManager.Add(car2);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }
        }
    }
}
