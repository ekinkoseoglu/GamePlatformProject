using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackBone.DataAccess.EntityFramework;
using Entities.Concrete;
using Entities.Dtos;
using GameDataAccess.Abstract;

namespace GameDataAccess.Concrete.EntityFramework
{
    public class EfGameDal : EfEntityRepositoryBase<Game, MyGameProjectContext>, IGameDal
    {
        public List<GameDetailDto> gameDetailDtos()
        {
            using (MyGameProjectContext context =new MyGameProjectContext())
            {
                var result = from p in context.Games // İki tablonun da kısaltılmıs harfini yazmalıyız  çünkü altta göründüğü gibi kullanmak zorunda kalacağız
                    join c in context.GameTypes
                        on p.TypeId equals c.TypeId
                    select new GameDetailDto() // Sonucu şu konulara uydurarak ver (Hangi özellikleri hangi tablodan alacağımızı burada belirliyoruz)
                    {
                        TypeId = p.TypeId,
                        GameName = p.GameName,
                        StudioId = p.StudioId,
                        GameId = p.GameId
                    };
                return result.ToList();
            }
        }
    }
}
