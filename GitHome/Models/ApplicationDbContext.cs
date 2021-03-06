﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace GitHome.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        // MY OBJECTS --> UNITS,UNITDETAILS, CLIENTS, AGENTS 
        public DbSet<Unit> Units { get; set; }

        public DbSet<UnitProperties> Properties { get; set; }
        public DbSet<Client> Clients { get; set; }

        public DbSet<Agent> Agents { get; set; }

        // CHECK IF ITS NECESSARY TO PUT THIS HERE
        public DbSet<Address> Addresses { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder
        //        .Entity<Unit>()
        //        .HasRequired(z => z.UnitDetail)
        //        .WithRequiredPrincipal()
        //        .WillCascadeOnDelete(false);

        //    base.OnModelCreating(modelBuilder);
        //}
    }

}