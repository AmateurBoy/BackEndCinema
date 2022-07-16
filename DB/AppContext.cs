using BackEndKino.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndKino.DB
{
    public class AppContext : DbContext
    {
        private static string IpServer = "(localdb)";
        private static string NameDB = "KinoDataBase";
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public AppContext()
        {
            Database.EnsureCreated();
        }       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server={IpServer}\\mssqllocaldb;Database={NameDB};Trusted_Connection=True;");
        }
    }
}
