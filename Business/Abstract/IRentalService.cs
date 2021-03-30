using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRentalService
    {
        DataResult<List<Rental>> GetAll();
        DataResult<Rental> GetById(int Id);
        Result Add(Rental rental);
        Result Delete(Rental rental);
        Result Update(Rental rental);
    }
}
