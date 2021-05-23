using BackBone.Utilities;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IGameTypeService
    {
        IDataResult<List<GameType>> GetAll();
        IDataResult<GameType> Get(int id);

        IResult Add(GameType entity);
        IResult Delete(int id);
        IResult Update(GameType entity);
    }
}
