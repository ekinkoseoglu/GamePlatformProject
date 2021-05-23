using Business.Concrete;
using GameDataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StudioManager studioManager = new StudioManager(new EfStudioDal());
            GameManager gameManager = new GameManager(new EfGameDal());
            foreach (var x in studioManager.GetAll().Data)
            {
                Console.WriteLine(x.StudioName);
            }

            Console.WriteLine("------");
            foreach (var x in gameManager.GetAll().Data)
            {
                Console.WriteLine(x.GameName);
            }

            GameTypeManager gameTypeManager = new GameTypeManager(new EfGameTypeDal());
            Console.WriteLine("------");
            foreach (var x in gameTypeManager.GetAll().Data)
            {
                Console.WriteLine(x.TypeName + "---" + x.TypeId);
            }

            Console.WriteLine("----------");

            //var result = gameTypeManager.Add(new GameType { TypeName = "Reflect" });
            //Console.WriteLine(result.Message);

            //foreach (var x in gameTypeManager.GetAll().Data)
            //{
            //    Console.WriteLine(x.TypeName);
            //}

            //Console.WriteLine(gameTypeManager.GetAll().Message);







        }
    }
}
