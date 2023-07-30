using System;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class ContactContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Link> Links { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=testAPI;Persist Security Info=True;User ID=web;Password=Password1!");
        }
    }
}
