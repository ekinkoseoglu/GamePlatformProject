using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
   public interface IStudioService
    {
        List<Studio> GetAll();
        Studio Get(int id);

        void Add(Studio entity);
        void Delete(Studio entity);
        void Update(Studio entity);
    }
}
