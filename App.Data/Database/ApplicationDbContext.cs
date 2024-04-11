﻿using App.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Data.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
    }
}
