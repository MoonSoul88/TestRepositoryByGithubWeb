using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BreakAwayContext : DbContext
    {
        public BreakAwayContext(string _ConnStr)
            : base(_ConnStr)
        {
        }

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging>     Lodgings     { get; set; }

        public DbSet<Trip>         Trips         { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DestinationConfiguration());
            modelBuilder.Configurations.Add(new LodgingConfiguration());
            modelBuilder.Configurations.Add(new TripConfiguration());

        }
    }
}
