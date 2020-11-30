using System;
using Microsoft.EntityFrameworkCore;

namespace AspWebApi50.Models {

    public class AppDbContext : DbContext {

        public DbSet<User> Users { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        }

    }
}
