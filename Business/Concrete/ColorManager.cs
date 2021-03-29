using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        private IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            this._colorDal = colorDal;
        }

        public Result Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColarAdded);
        }

        public Result Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColarDeleted);
        }

        public DataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),Messages.ColarListed);
        }

        public DataResult<Color> GetById(int colorId)
        {
          return new SuccessDataResult<Color>(_colorDal.Get(c => c.ColorId == colorId));
        }

        public Result Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColarUpdated);
        }
    }
}
