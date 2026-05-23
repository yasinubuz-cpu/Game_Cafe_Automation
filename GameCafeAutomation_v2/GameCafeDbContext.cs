using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GameCafeAutomation.Models;

namespace GameCafeAutomation.Data
{
    public class GameCafeDbContext : DbContext
    {
        public GameCafeDbContext() : base("GameCafeDbContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Session> Sessions { get; set; }
    }
}
