﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 100, ModelYear = 2021, Description = "2 günlük kiralanabilir."},
                new Car{Id = 2, BrandId = 2, ColorId = 4, DailyPrice = 110, ModelYear = 2021, Description = "2 günlük kiralanabilir."},
                new Car{Id = 3, BrandId = 3, ColorId = 2, DailyPrice = 120, ModelYear = 2021, Description = "2 günlük kiralanabilir."},
                new Car{Id = 4, BrandId = 2, ColorId = 3, DailyPrice = 130, ModelYear = 2021, Description = "2 günlük kiralanabilir."},
                new Car{Id = 5, BrandId = 5, ColorId = 2, DailyPrice = 140, ModelYear = 2021, Description = "2 günlük kiralanabilir."},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}