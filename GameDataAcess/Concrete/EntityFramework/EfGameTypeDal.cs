using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackBone.DataAccess.EntityFramework;
using Entities.Concrete;
using GameDataAccess.Abstract;

namespace GameDataAccess.Concrete.EntityFramework
{
   public class EfGameTypeDal:EfEntityRepositoryBase<GameType,MyGameProjectContext>,IGameTypeDal
    {
    }
}
