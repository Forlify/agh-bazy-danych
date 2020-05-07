using System;
using Microsoft.EntityFrameworkCore;

namespace BlazejKustraHellow
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceProduct> InvoiceProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("DataSource=Product.db");

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<InvoiceProduct>().HasKey(item =>
            new { item.ProductID, item.InvoiceID });

            model.Entity<Customer>();
            model.Entity<Supplier>();
        }
    }
}
