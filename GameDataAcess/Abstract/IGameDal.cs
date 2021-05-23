using BackBone.DataAccess;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;

namespace GameDataAccess.Abstract
{
    public interface IGameDal : IEntityRepository<Game>
    {
        List<GameDetailDto> gameDetailDtos();
    }
}
