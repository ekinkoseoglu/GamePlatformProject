using Business.Abstract;

using Entities.Concrete;
using System;
using System.Collections.Generic;
using GameDataAccess.Abstract;

namespace Business.Concrete
{
    public class GameManager:IGameService
   {
       private IGameDal _gameDal;

       public GameManager(IGameDal gameDal)
       {
           _gameDal = gameDal;
       }

       public List<Game> GetAll()
       {
           return _gameDal.GetAll();
       }

       public List<Game> GetByPrice(decimal min, decimal max)
       {
           return _gameDal.GetAll(p => p.Price <= min && p.Price >= max);
       }

       public Game Get(int id)
       {
           return _gameDal.Get(p=>p.GameId== id);
       }

       public void Add(Game entity)
       {
           _gameDal.Add(entity);
       }

       public void Delete(Game entity)
       {
           var deletedGame = _gameDal.Get(p => p.GameId == entity.GameId);
           _gameDal.Delete(deletedGame);
       }

       public void Update(Game entity)
       {
           _gameDal.Update(entity);
       }
   }

    
}
