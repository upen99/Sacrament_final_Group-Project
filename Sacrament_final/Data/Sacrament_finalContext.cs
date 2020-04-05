using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sacrament_final.Models;

namespace Sacrament_final.Data
{
    public class Sacrament_finalContext : DbContext
    {
        public Sacrament_finalContext (DbContextOptions<Sacrament_finalContext> options)
            : base(options)
        {
        }

        public DbSet<Sacrament_final.Models.Sacrament> Sacrament { get; set; }
    }
}
