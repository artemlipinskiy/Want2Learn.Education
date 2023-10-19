using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Want2Learn.EF.Entities;

namespace Want2Learn.EF
{
    public class TestDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Flat> Flats { get; set; }
        public DbSet<Owner> Owners { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Street>().Property(u => u.Name).HasColumnName("StreetName");
            //modelBuilder.Entity<Street>().HasOne(x => x.City).WithMany(x => x.Streets).HasForeignKey(x => x.CityId).OnDelete(DeleteBehavior.Restrict).IsRequired();

            modelBuilder.Entity("Want2Learn.EF.Entities.Street", b =>
            {
                b.HasOne("Want2Learn.EF.Entities.City", "City")
                    .WithMany("Streets")
                    .HasForeignKey("CityId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                b.Navigation("City");
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=MyTestDb;Initial Catalog=MyTestDb;Integrated Security=True;");
        }
    }
}
