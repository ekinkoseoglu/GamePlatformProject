using BackBone.Entities;

namespace Entities.Concrete
{
    public class Studio : IEntity
    {
        public int StudioId { get; set; }
        public string StudioName { get; set; }
    }
}
