﻿using Microsoft.EntityFrameworkCore;

namespace my_database.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
