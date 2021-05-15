using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using GameDataAccess.Abstract;

namespace Business.Concrete
{
   public class StudioManager:IStudioService
   {
       private IStudioDal _studioDal;

       public StudioManager(IStudioDal studioDal)
       {
           _studioDal = studioDal;
       }

       public List<Studio> GetAll()
       {
           return _studioDal.GetAll();
       }

       public Studio Get(int id)
       {
           return _studioDal.Get(p=>p.StudioId==id);
       }

       public void Add(Studio entity)
       {
           _studioDal.Add(entity);
       }

       public void Delete(Studio entity)
       {
           var deletedStudio = _studioDal.Get(p => p.StudioId == entity.StudioId);
           _studioDal.Delete(deletedStudio);
       }

       public void Update(Studio entity)
       {
           _studioDal.Update(entity);
       }
   }
}
