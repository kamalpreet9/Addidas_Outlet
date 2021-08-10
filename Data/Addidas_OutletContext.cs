using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Addidas_Outlet.Models;

namespace Addidas_Outlet.Data
{
    public class Addidas_OutletContext : DbContext
    {
        public Addidas_OutletContext (DbContextOptions<Addidas_OutletContext> options)
            : base(options)
        {
        }

        public DbSet<Addidas_Outlet.Models.Categories> Categories { get; set; }

        public DbSet<Addidas_Outlet.Models.Product> Product { get; set; }

        public DbSet<Addidas_Outlet.Models.Order> Order { get; set; }

        public DbSet<Addidas_Outlet.Models.Sub_Category> Sub_Category { get; set; }
    }
}
