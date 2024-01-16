using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

// dotnet tool install --global dotnet-ef --version 8.0.0
// dotnet ef migrations add init
// dotnet ef database update

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
        public DbSet<Models.Stock> Stocks { get; set; } = null!;
        public DbSet<Models.Comment> Comments { get; set; } = null!;
    }
}