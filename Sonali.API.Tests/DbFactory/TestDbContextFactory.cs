using Microsoft.EntityFrameworkCore;
using Sonali.API.Infrastructure.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Tests.DbFactory
{
    public static class TestDbContextFactory
    {
        public static TestAppDbContext CreateInMemoryDbContext(string dbName = "TestDb")
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: dbName)
                .Options;

            return new TestAppDbContext(options);
        }
    }
}
