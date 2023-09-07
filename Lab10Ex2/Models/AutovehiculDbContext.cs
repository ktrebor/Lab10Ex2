using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab10Ex2.Models
{
    internal class AutovehiculDbContext : DbContext
    {
        public DbSet<Autovehicul> Autovehicul { get; set; }

        public AutovehiculDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rober\source\repos\Lab10Ex2\Lab10Ex2\AutovehiculDb.mdf;Integrated Security=True");
        }
    }
}
