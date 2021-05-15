using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackBone.Entities;

namespace Entities.Concrete
{
    public class GameType: IEntity
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }
    }
}
