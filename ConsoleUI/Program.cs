using Business.Concrete;
using System;
using System.Data;
using System.Linq;
using Business.Constants;
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
            Customer customer1 = new Customer { CompanyName = "denemee", UserId = 1 };
            User user1 = new User { FirstName = "zeynel", LastName = "uçar", Email = "deneme@asdf.asd", Password = "1234234" };
            Rental rental1 = new Rental { CarId = 3, CustomerId = 2, RentDate = new DateTime(2021, 03, 15), ReturnDate = new DateTime(2021,03,21)};


            //CustomerTest(customer1);
            //UserTest(user1);
            //RentalTest(rental1);
            //CarTest(car2);
            //BrandTest(brand2);
            //ColorTest(color2);
            //CarDetailDtoTest();
        }

        private static void CustomerTest(Customer customer1)
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Console.WriteLine(customerManager.Add(customer1).Message);
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.CompanyName);
            }
        }

        private static void UserTest(User user1)
        {
            UserManager userManager = new UserManager(new EfUserDal());
            Console.WriteLine(userManager.Add(user1).Message);
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName);
            }
        }

        private static void RentalTest(Rental rental1)
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Console.WriteLine(rentalManager.Add(rental1).Message);
            foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine(rental.Id);
            }
        }

        private static void CarDetailDtoTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.DailyPrice + "/" + car.BrandName + "/" + car.CarName + "/" + car.ColorName);
            }
        }

        private static void ColorTest(Color color2)
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Console.WriteLine(colorManager.Add(color2).Message);
            colorManager.Update(new Color { ColorId = 1002, ColorName = "testt" });
            colorManager.Delete(new Color { ColorId = 1002 });
            Console.WriteLine(colorManager.GetById(4).Data.ColorName);
            foreach (var color in colorManager.GetAll().Data)
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
            Console.WriteLine(brandManager.GetById(4).Data);
            foreach (var brand in brandManager.GetAll().Data)
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
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.CarName);
            }
        }
    }
}
