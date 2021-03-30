using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        DataResult<List<Customer>> GetAll();
        DataResult<Customer> GetById(int customerId);
        Result Add(Customer customer);
        Result Delete(Customer customer);
        Result Update(Customer customer);
    }
}
