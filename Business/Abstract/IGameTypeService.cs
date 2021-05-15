using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
   public interface IGameTypeService
   {
       List<GameType> GetAll();
       GameType Get(int id);

       void Add(GameType entity);
       void Delete(GameType entity);
       void Update(GameType entity);
    }
}
