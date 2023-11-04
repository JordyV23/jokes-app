using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using jokes_app.Models;

namespace jokes_app.Data
{
    public class jokes_appDbContext : DbContext
    {
        public jokes_appDbContext (DbContextOptions<jokes_appDbContext> options)
            : base(options)
        {
        }

        public DbSet<jokes_app.Models.Joke> Joke { get; set; } = default!;
    }
}
