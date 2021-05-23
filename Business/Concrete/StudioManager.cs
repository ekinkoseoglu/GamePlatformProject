using BackBone.Utilities;
using Business.Abstract;
using Business.Constants;
using Entities.Concrete;
using GameDataAccess.Abstract;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class StudioManager : IStudioService
    {
        private IStudioDal _studioDal;

        public StudioManager(IStudioDal studioDal)
        {
            _studioDal = studioDal;
        }

        public IDataResult<List<Studio>> GetAll()
        {
            if (DateTime.Now.Hour > 23 && DateTime.Now.Hour < 7)
            {
                return new ErrorDataResult<List<Studio>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Studio>>(_studioDal.GetAll(),Messages.StudioListed);
        }

        public IDataResult<Studio> Get(int id)
        {
            if (DateTime.Now.Hour > 23 && DateTime.Now.Hour < 7)
            {
                return new ErrorDataResult<Studio>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<Studio>(_studioDal.Get(p => p.StudioId == id),Messages.HasShown);
        }

        public IResult Add(Studio entity)
        {
            if (DateTime.Now.Hour > 23 && DateTime.Now.Hour < 7)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            _studioDal.Add(entity);
            return new SuccessResult(Messages.StudioAdded);
        }

        public IResult Delete(Studio entity)
        {
            if (DateTime.Now.Hour > 23 && DateTime.Now.Hour < 7)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            var deletedStudio = _studioDal.Get(p => p.StudioId == entity.StudioId);
            _studioDal.Delete(deletedStudio);
            return new SuccessResult(Messages.DeletedGame);
        }

        public IResult Update(Studio entity)
        {
            if (DateTime.Now.Hour > 23 && DateTime.Now.Hour < 7)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            _studioDal.Update(entity);
            return new SuccessResult(Messages.StudioUpdated);
        }
    }
}
