using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TruongShop.Data.Entities;

namespace TruongShop.Data.EF
{
    public class TruongDoShopDbContext : DbContext
    {
        public TruongDoShopDbContext(DbContextOptions options) : base(options)
        {   
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
