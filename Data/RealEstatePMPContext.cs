using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RealEstatePMP.Models;

namespace RealEstatePMP.Data
{
    public class RealEstatePMPContext : DbContext
    {
        public RealEstatePMPContext (DbContextOptions<RealEstatePMPContext> options)
            : base(options)
        {
        }

        public DbSet<RealEstatePMP.Models.Agent> Agent { get; set; }

        public DbSet<RealEstatePMP.Models.City> City { get; set; }

        public DbSet<RealEstatePMP.Models.Dwelling> Dwelling { get; set; }

        public DbSet<RealEstatePMP.Models.SalesOffice> SalesOffice { get; set; }
    }
}
