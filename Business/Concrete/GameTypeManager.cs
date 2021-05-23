using BackBone.Utilities;
using Business.Abstract;
using Business.Constants;
using Entities.Concrete;
using GameDataAccess.Abstract;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class GameTypeManager : IGameTypeService
    {
        private IGameTypeDal _gameTypeDal;

        public GameTypeManager(IGameTypeDal gameTypeDal)
        {
            _gameTypeDal = gameTypeDal;
        }

        public IDataResult<List<GameType>> GetAll()
        {
            if (DateTime.Now.Hour > 23 && DateTime.Now.Hour < 7)
            {
                return new ErrorDataResult<List<GameType>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<GameType>>(_gameTypeDal.GetAll(), Messages.TypeListed);
        }

        public IDataResult<GameType> Get(int id)
        {
            if (DateTime.Now.Hour > 23 && DateTime.Now.Hour < 7)
            {
                return new ErrorDataResult<GameType>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<GameType>(_gameTypeDal.Get(p => p.TypeId == id), Messages.HasShown);

        }

        public IResult Add(GameType entity)
        {
            if (DateTime.Now.Hour > 23 && DateTime.Now.Hour < 7)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            _gameTypeDal.Add(entity);
            return new SuccessResult(Messages.TypeAdded);
        }

        public IResult Delete(int id)
        {
            if (DateTime.Now.Hour > 23 && DateTime.Now.Hour < 7)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            var deletedType = _gameTypeDal.Get(p => p.TypeId == id);
            _gameTypeDal.Delete(deletedType);
            return new SuccessResult(Messages.TypeDeleted);
        }

        public IResult Update(GameType entity)
        {
            if (DateTime.Now.Hour > 23 && DateTime.Now.Hour < 7)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            _gameTypeDal.Update(entity);
            return new SuccessResult(Messages.TypeUpdated);
        }
    }
}
