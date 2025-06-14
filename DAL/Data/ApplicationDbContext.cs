﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=\"cafitaria system\";Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Order.Total
            modelBuilder.Entity<Order>()
                .Property(o => o.Total)
                .HasPrecision(18, 2);

            // Product.Cost
            modelBuilder.Entity<Product>()
                .Property(p => p.Cost)
                .HasPrecision(18, 2);

            // Product.PricePerUnit
            modelBuilder.Entity<Product>()
                .Property(p => p.PricePerUnit)
                .HasPrecision(18, 2);


            modelBuilder.Entity<Inventory>()
            .HasOne(i => i.Product)
            .WithOne(p => p.Inventory)
            .HasForeignKey<Inventory>(i => i.ProductId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderItem>()
            .HasIndex(oi => new { oi.ProductId , oi.OrderId})
            .IsUnique();

            modelBuilder.Entity<OrderItem>()
             .HasOne(oi => oi.Product)
             .WithMany(p => p.OrderItem)
             .HasForeignKey(oi => oi.ProductId)
             .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Product>()
           .HasIndex(p => p.ProductName)
           .IsUnique();


        }


    }
}
