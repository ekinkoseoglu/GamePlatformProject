using BackBone.Utilities;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStudioService
    {
        IDataResult<List<Studio>> GetAll();
        IDataResult<Studio> Get(int id);

        IResult Add(Studio entity);
        IResult Delete(Studio entity);
        IResult Update(Studio entity);
    }
}
