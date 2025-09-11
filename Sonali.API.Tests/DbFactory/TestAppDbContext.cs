using Microsoft.EntityFrameworkCore;
using Sonali.API.Infrastructure.Data.Data;
using Sonali.API.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Tests.DbFactory
{
    public class TestAppDbContext : AppDbContext
    {
        public TestAppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Skip SQL Server provider completely for tests
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Override Id configuration for testing only
            modelBuilder.Entity<Accgl2025>()
                .Property(e => e.Id)
                .ValueGeneratedNever(); // <-- EF won't expect a generator
        }
    }
}
