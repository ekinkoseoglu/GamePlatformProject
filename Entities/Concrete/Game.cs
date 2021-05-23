using BackBone.Entities;

namespace Entities.Concrete
{
    public class Game : IEntity
    {

        public int GameId { get; set; }
        public int TypeId { get; set; }
        public int StudioId { get; set; }
        public decimal Price { get; set; }
        public string GameName { get; set; }
        public string ReleaseDate { get; set; }
    }
}
