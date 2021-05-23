using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackBone.Utilities;
using Entities.Concrete;

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
