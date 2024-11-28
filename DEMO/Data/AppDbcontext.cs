using DEMO.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace DEMO.Data
{
    public class AppDbcontext:DbContext
    {

        public AppDbcontext(DbContextOptions<AppDbcontext> options):base(options) { }
        

        public AppDbcontext() { }

        public DbSet <Destination> destinations { get; set; }

        public DbSet <Utilisateur> utilisateurs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
