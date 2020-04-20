using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
            .HasData(
                new Value{Id=1,Name="Ashok"},
                new Value{Id=2,Name="Ashok1"},
                new Value{Id=3,Name="Ashok12"},
                new Value{Id=4,Name="Ashok123"},
                new Value{Id=5,Name="Ashok1234"}
            );
        }
    }
}
