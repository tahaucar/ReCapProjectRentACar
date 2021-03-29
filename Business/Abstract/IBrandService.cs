using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        DataResult<List<Brand>> GetAll();
        DataResult<Brand> GetById(int brandId);
        Result Add(Brand brand);
        Result Delete(Brand brand);
        Result Update(Brand brand);
    }
}
