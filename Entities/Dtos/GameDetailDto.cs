using BackBone.Entities;

namespace Entities.Dtos
{
    public class GameDetailDto : IDto
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public int TypeId { get; set; }
        public int StudioId { get; set; }
    }
}
