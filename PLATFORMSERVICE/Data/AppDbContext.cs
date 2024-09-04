﻿using Microsoft.EntityFrameworkCore;
using PLATFORMSERVICE.Model;

namespace PLATFORMSERVICE.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext( DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        public DbSet<PlatForm> platforms { get; set; }
    }
}
