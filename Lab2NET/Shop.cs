using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2NET
{
    internal class Shop : DbContext
    {
        public Shop()
        {
            Database.EnsureCreated();
        }
        public virtual DbSet<BeerDB> Beers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite(@"Data Source=BeerDB.db");

    }
}
