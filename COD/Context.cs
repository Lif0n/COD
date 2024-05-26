using Microsoft.EntityFrameworkCore;
using COD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD
{
    public class Context : DbContext
    {
        private string _connectionString = "Data Source=DESKTOP-HIITB3O; initial Catalog=biba;Integrated Security=True;TrustServerCertificate=True";
        /*        private readonly string _connectionString = "Data Source=192.168.221.12; initial Catalog=BesSenTaskManager;" +
           "User ID=user05;Password=05;TrustServerCertificate=True";*/

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        public Context()
        {

        }
    }
}
