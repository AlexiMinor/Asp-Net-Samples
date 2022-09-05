﻿using AspBetSample.DataBase.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspBetSample.DataBase;

public class GoodNewsAggregatorContext : DbContext
{
    public DbSet<Article> Articles { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Source> Sources { get; set; }
    public DbSet<User> Users { get; set; }

    public GoodNewsAggregatorContext(DbContextOptions<GoodNewsAggregatorContext> options) 
        : base(options)
    {
    }
}