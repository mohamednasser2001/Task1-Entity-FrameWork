using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_Entity_FrameWork.Models;

namespace Task1_Entity_FrameWork.Data
{
    internal class ApplicationDbContext: DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Store> stores { get; set; }
        public DbSet<Sale> sales { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TaskEntity1;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .Property(q => q.Name)
                .HasColumnType("varchar(50)");
            modelBuilder.Entity<Product>()
                .Property(q => q.Name)
                .IsUnicode (true);
            modelBuilder.Entity<Customer>()
                .Property(q => q.Name)
                .HasColumnType("varchar(100)");
            modelBuilder.Entity<Customer>()
                .Property(q => q.Name)
                .IsUnicode(true);
            modelBuilder.Entity<Customer>()
                .Property(q => q.Email)
                .HasColumnType("varchar(80)");
            modelBuilder.Entity<Customer>()
                .Property(q => q.Email)
                .IsUnicode(false);
            modelBuilder.Entity<Store>()
                .Property(q => q.Name)
                .HasColumnType("varchaar(80)")
                .IsUnicode(true);



        }
    }
}
