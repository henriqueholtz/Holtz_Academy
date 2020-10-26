using Holtz_Academy.API.Entities;
using Holtz_Academy.API.Entities.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teatcher> Teatchers { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Equipament> Equipaments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TeatcherConfiguration());
            modelBuilder.ApplyConfiguration(new BranchConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new EquipamentConfiguration());

            /*//STUDENT
            modelBuilder.Entity<Student>()
                .HasKey(key => key.StudentCode);
            //TEATCHER
            modelBuilder.Entity<Teatcher>()
                .HasKey(key => key.TeatcherCode);
            modelBuilder.Entity<Teatcher>() //Onde Teatcher have many students, and one student have one teatcher
                .HasMany(p => p.Students)
                .WithOne(a => a.Teatcher)
                .HasForeignKey(f => f.TeatcherCode)
                .OnDelete(DeleteBehavior.Restrict);
            //BRANCH
            modelBuilder.Entity<Branch>()
                .HasKey(key => key.BranchCode);
            modelBuilder.Entity<Branch>() //One Branch have many students, and onde student have one Branch
                .HasMany(a => a.Students)
                .WithOne(b => b.Branch)
                .HasForeignKey(f => f.StudentCode)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Branch>() //One Branch have many teatchers, and one teatcher have one Branch
                .HasMany(a => a.Teatchers)
                .WithOne(b => b.Branch)
                .HasForeignKey(f => f.BranchCode)
                .OnDelete(DeleteBehavior.Restrict);
            //EQUIPAMENT
            modelBuilder.Entity<Equipament>()
                .HasKey(key => key.EquipamentCode);*/
        }
    }
}
