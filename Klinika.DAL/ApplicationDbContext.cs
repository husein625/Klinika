using Klinika.DAL.Configuration;
using Klinika.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Klinika.DAL
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Pacijent> Pacijent { get; set; }
        public DbSet<Spol> Spol { get; set; }

        public DbSet<Ljekar> Ljekar { get; set; }
        public DbSet<Titula> Titula { get; set; }

        public DbSet<Prijem> Prijem { get; set; }

        public DbSet<Nalaz> Nalaz { get; set; }




        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PacijentConfiguration());
            builder.ApplyConfiguration(new SpolConfiguration());
            builder.ApplyConfiguration(new LjekarConfiguration());
            builder.ApplyConfiguration(new TitulaConfiguration());
            builder.ApplyConfiguration(new PrijemConfiguration());
            builder.ApplyConfiguration(new NalazConfiguration());
            base.OnModelCreating(builder);

        }

    }
}
