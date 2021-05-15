using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using GameDataAccess.Abstract;

namespace Business.Concrete
{
   public class GameTypeManager:IGameTypeService
   {
       private IGameTypeDal _gameTypeDal;

       public GameTypeManager(IGameTypeDal gameTypeDal)
       {
           _gameTypeDal = gameTypeDal;
       }

       public List<GameType> GetAll()
       {
          return _gameTypeDal.GetAll();
       }

        public GameType Get(int id)
        {
            return _gameTypeDal.Get(p=>p.TypeId==id);

        }

        public void Add(GameType entity)
        {
            _gameTypeDal.Add(entity);
        }

        public void Delete(GameType entity)
        {
            var deletedType = _gameTypeDal.Get(p => p.TypeId == entity.TypeId);
            _gameTypeDal.Delete(deletedType);
        }

        public void Update(GameType entity)
        {
            _gameTypeDal.Update(entity);
        }
    }
}
