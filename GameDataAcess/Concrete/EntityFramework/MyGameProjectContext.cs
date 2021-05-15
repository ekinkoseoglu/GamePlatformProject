using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace GameDataAccess.Concrete.EntityFramework
{
   public class MyGameProjectContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MyGameProjectDB;Trusted_Connection=true;");
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<GameType> GameTypes { get; set; }
        public DbSet<Studio> Studios { get; set; }
    }
}
