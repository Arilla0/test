using System;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class MyContext: DbContext
    {
        public DbSet<CarModels> CarModels { get; set; }
        public DbSet<CarTrims> CarTrims { get; set; }
        public DbSet<CarVariant> CarVariant { get; set; }
        public DbSet<CarOrders> CarOrders { get; set; }
        public DbSet<Customers> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=192.168.0.150;Initial Catalog=testAPI;Persist Security Info=True;User ID=sa;Password=Password1!");
        }
    }
}
