using BackBone.DataAccess.EntityFramework;
using Entities.Concrete;
using GameDataAccess.Abstract;

namespace GameDataAccess.Concrete.EntityFramework
{
    public class EfStudioDal : EfEntityRepositoryBase<Studio, MyGameProjectContext>, IStudioDal
    {
    }
}
