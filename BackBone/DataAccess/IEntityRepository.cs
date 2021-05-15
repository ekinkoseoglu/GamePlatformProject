using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BackBone.Entities;

namespace BackBone.DataAccess
{
   public interface IEntityRepository<T> where T: class, IEntity,new()
   {
       List<T> GetAll(Expression<Func<T,bool>> filter = null);
       T Get(Expression<Func<T, bool>> filter);
       void Add(IEntity entity);
       void Update(IEntity entity);
       void Delete(IEntity entity);
   }
}
