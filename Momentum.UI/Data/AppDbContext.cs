using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Momentum.UI.Models;

namespace Momentum.UI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Momentum.UI.Models.DocenteLocal> DocenteLocal { get; set; } = default!;
    }
}
