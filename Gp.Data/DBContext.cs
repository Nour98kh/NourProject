using Gp.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gp.Data
{
    public class DBContext : DbContext
    {
        public DbSet<Member> Members { get; set; } //image virtuel des tables en utilisant DBSet
        public DbSet<Abonnement> Abonnements { get; set; }

        public DBContext(DbContextOptions<DBContext> options)
           : base(options)
        {

        }

        public DBContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //méth pour conf toutes les entités et leurs propriétés
        {
            /*modelBuilder.Entity<Member>().HasMany(p => p.Abonnements).WithMany(p => p.Members).Map(m =>
            {
                m.MapLeftKey("CodeAbo");
                m.MapRightKey("MemberId");
                m.ToTable("Abonnement");
            });


            modelBuilder.Entity<Abonnement>().HasMany(p => p.Members).WithMany(p => p.Abonnements).Map(m =>
            {
                m.MapLeftKey("MemberId");
                m.MapRightKey("CodeAbo");
                m.ToTable("Abonnement");
            });*/


        }
    }
}
