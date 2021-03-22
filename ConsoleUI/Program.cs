using Business.Concrete;
using System;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car2 = new Car{ BrandId = 2, ColorId = 2, ModelYear = 2020, DailyPrice = 0, Description = "deeeeee" };
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(car2);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId);
            }

        }
    }
}
