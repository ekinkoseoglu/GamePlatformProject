using BackBone.Utilities;
using Business.Abstract;
using Business.Constants;
using Entities.Concrete;
using GameDataAccess.Abstract;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class GameManager : IGameService
    {
        private IGameDal _gameDal;

        public GameManager(IGameDal gameDal)
        {
            _gameDal = gameDal;
        }

        public IDataResult<List<Game>> GetAll()
        {
            if (DateTime.Now.Hour > 23 && DateTime.Now.Hour < 7)
            {
                return new ErrorDataResult<List<Game>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Game>>(_gameDal.GetAll(), Messages.ListedGame);
        }

        public IDataResult<List<Game>> GetByPrice(decimal min, decimal max)
        {
            if (DateTime.Now.Hour > 23 && DateTime.Now.Hour < 7)
            {
                return new ErrorDataResult<List<Game>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Game>>(_gameDal.GetAll(p => p.Price <= min && p.Price >= max), Messages.ListedGame);
        }

        public IDataResult<Game> Get(int id)
        {
            if (DateTime.Now.Hour > 23 && DateTime.Now.Hour < 7)
            {
                return new ErrorDataResult<Game>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<Game>(_gameDal.Get(p => p.GameId == id), Messages.HasShown);
        }

        public IResult Add(Game entity)
        {
            if (DateTime.Now.Hour > 23 && DateTime.Now.Hour < 7)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            _gameDal.Add(entity);
            return new SuccessResult(Messages.AddedGame);
        }

        public IResult Delete(Game entity)
        {
            if (DateTime.Now.Hour > 23 && DateTime.Now.Hour < 7)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            var deletedGame = _gameDal.Get(p => p.GameId == entity.GameId);
            _gameDal.Delete(deletedGame);
            return new SuccessResult(Messages.DeletedGame);
        }

        public IResult Update(Game entity)
        {
            if (DateTime.Now.Hour > 23 && DateTime.Now.Hour < 7)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            _gameDal.Update(entity);
            return new SuccessResult(Messages.UpdatedGame);
        }
    }


}
