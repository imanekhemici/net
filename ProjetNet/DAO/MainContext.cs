using Projet_ASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Projet_ASP.DAO
{
    public class MainContext:DbContext
    {
        public DbSet<Employe> Employe { get; set; }

        public DbSet<Roles> Roles { get; set; }

        public DbSet<Metier> Metier { get; set; }

        public DbSet<Employe_Metier> Employe_Metier { get; set; }

        public DbSet<Employe_Role> Employe_Role { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //one-to-many
            modelBuilder.Entity<Employe>()
                        .HasMany<Employe_Metier>(s => s.Metiers)
                        .WithRequired(s => s.Employe)
                        .HasForeignKey(s => s.EmployeRefId);

            //one-to-many
            modelBuilder.Entity<Metier>()
                        .HasMany<Employe_Metier>(s => s.Employes)
                        .WithRequired(s => s.Metier)
                        .HasForeignKey(s => s.MetierRefId);

            //one-to-many
            modelBuilder.Entity<Employe>()
                        .HasMany<Employe_Role>(s => s.Roles)
                        .WithRequired(s => s.Employe)
                        .HasForeignKey(s => s.EmployeRefId);

            //one-to-many
            modelBuilder.Entity<Roles>()
                        .HasMany<Employe_Role>(s => s.Employes)
                        .WithRequired(s => s.Role)
                        .HasForeignKey(s => s.RoleRefId);

            base.OnModelCreating(modelBuilder);
        }


    }

}