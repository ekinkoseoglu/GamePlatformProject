using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackBone.Entities;

namespace Entities.Concrete
{
    public class GameType: IEntity
    {
        [Key]
        public int TypeId { get; set; }
        public string TypeName { get; set; }
    }
}
