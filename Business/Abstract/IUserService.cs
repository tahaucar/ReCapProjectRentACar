using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        DataResult<List<User>> GetAll();
        DataResult<User> GetById(int userId);
        Result Add(User user);
        Result Delete(User user);
        Result Update(User user);

    }
}
