using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        DataResult<List<Car>> GetAll();
        DataResult<List<Car>> GetCarsByBrandId(int brandId);
        DataResult<List<Car>> GetCarsByColorId(int colorId);
        DataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
        DataResult<List<CarDetailDto>> GetCarDetails();
        Result Add(Car car);
        Result Delete(Car car);
        Result Update(Car car);

    }
}
