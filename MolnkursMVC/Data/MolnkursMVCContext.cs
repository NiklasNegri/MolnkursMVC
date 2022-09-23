using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MolnkursMVC.Models;

namespace MolnkursMVC.Data
{
    public class MolnkursMVCContext : DbContext
    {
        public MolnkursMVCContext (DbContextOptions<MolnkursMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MolnkursMVC.Models.Movie> Movie { get; set; } = default!;
    }
}
