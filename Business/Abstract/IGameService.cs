using BackBone.Utilities;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IGameService
    {
        IDataResult<List<Game>> GetAll();
        IDataResult<List<Game>> GetByPrice(decimal min, decimal max);
        IDataResult<Game> Get(int id);

        IResult Add(Game entity);
        IResult Delete(Game entity);
        IResult Update(Game entity);
    }
}
