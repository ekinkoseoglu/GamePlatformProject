using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackBone.DataAccess;
using Entities.Concrete;

namespace GameDataAccess.Abstract
{
   public interface IGameTypeDal:IEntityRepository<GameType>
    {
    }
}
