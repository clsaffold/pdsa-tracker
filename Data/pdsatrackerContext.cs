using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pdsatracker.Models;

namespace pdsatracker.Data
{
    public class pdsatrackerContext : DbContext
    {
        public pdsatrackerContext (DbContextOptions<pdsatrackerContext> options)
            : base(options)
        {
        }

        public DbSet<pdsatracker.Models.Pdsa> Pdsa { get; set; }
    }
}
