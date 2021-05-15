using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
   public interface IGameService
   {
       List<Game> GetAll();
       List<Game> GetByPrice(decimal min, decimal max);
       Game Get(int id);

       void Add(Game entity);
       void Delete(Game entity);
       void Update(Game entity);
    }
}
