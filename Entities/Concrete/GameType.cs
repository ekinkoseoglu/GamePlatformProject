using BackBone.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class GameType : IEntity
    {
        [Key]
        public int TypeId { get; set; }
        public string TypeName { get; set; }
    }
}
