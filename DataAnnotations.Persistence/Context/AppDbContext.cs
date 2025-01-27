﻿using DataAnnotations.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAnnotations.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<UserModel> Users { get; set; }
    }
}
