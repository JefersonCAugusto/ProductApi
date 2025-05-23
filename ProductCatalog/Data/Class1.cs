﻿using Domain;
using Microsoft.EntityFrameworkCore;

namespace ProductApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options) { }

    public DbSet<Product> Products => Set<Product>();
}
