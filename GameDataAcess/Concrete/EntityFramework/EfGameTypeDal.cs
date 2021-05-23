using BackBone.DataAccess.EntityFramework;
using Entities.Concrete;
using GameDataAccess.Abstract;

namespace GameDataAccess.Concrete.EntityFramework
{
    public class EfGameTypeDal : EfEntityRepositoryBase<GameType, MyGameProjectContext>, IGameTypeDal
    {
    }
}
