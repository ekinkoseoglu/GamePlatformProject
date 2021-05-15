using System;
using Business.Concrete;
using GameDataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StudioManager studioManager = new StudioManager(new EfStudioDal());
            GameManager gameManager = new GameManager(new EfGameDal());
            foreach (var x in studioManager.GetAll())
            {
                Console.WriteLine(x.StudioName);
            }

            Console.WriteLine("------");
            foreach (var x in gameManager.GetAll())
            {
                Console.WriteLine(x.GameName);
            }

            GameTypeManager gameTypeManager = new GameTypeManager(new EfGameTypeDal());
            Console.WriteLine("------");
            foreach (var x in gameTypeManager.GetAll())
            {
                Console.WriteLine(x.TypeName);
            }

        }
    }
}
