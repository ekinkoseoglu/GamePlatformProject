using BackBone.DataAccess;
using Entities.Concrete;

namespace GameDataAccess.Abstract
{
    public interface IGameTypeDal : IEntityRepository<GameType>
    {
    }
}
