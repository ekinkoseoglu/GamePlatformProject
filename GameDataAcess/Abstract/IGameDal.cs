using BackBone.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.Dtos;

namespace GameDataAccess.Abstract
{
   public interface IGameDal:IEntityRepository<Game>
   {
       List<GameDetailDto> gameDetailDtos();
   }
}
