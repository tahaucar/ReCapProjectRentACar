using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        DataResult<List<Color>> GetAll();
        DataResult<Color> GetById(int colorId);
        Result Add(Color color);
        Result Delete(Color color);
        Result Update(Color color);
    }
}
