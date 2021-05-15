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
            foreach (var x in studioManager.GetAll())
            {
                Console.WriteLine(x.StudioName);
            }

        }
    }
}
