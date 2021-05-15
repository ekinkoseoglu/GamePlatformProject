using BackBone.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

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
