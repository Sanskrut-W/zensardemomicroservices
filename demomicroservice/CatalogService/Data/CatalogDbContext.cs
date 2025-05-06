﻿using Microsoft.EntityFrameworkCore;
using CatelogService.Data;
using CatalogService.Models;


namespace CatelogService.Data
{
    public class CatelogDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public CatelogDbContext(DbContextOptions<CatelogDbContext> options) : base(options)
        {
        }
    }
}