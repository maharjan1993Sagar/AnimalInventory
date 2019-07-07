using AnimalInventory.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalInventory.Core
{
    public class AnimalContext: DbContext
    {
        public AnimalContext(DbContextOptions<AnimalContext> options)
        : base(options)
        {

        }
      
        public DbSet<User>  Users { get; set; }
      
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<AnimalOwner>()
        //        .HasKey(bc => new { bc.AnimalId, bc.OwnerId });
        //    modelBuilder.Entity<AnimalOwner>()
        //        .HasOne(bc => bc.Owner)
        //        .WithMany(b => b.AnimalOwners)
        //        .HasForeignKey(bc => bc.OwnerId);
        //    modelBuilder.Entity<AnimalOwner>()
        //        .HasOne(bc => bc.AnimalRegistration)
        //        .WithMany(c => c.AnimalOwners)
        //        .HasForeignKey(bc => bc.AnimalId);
        //}



    }
}
