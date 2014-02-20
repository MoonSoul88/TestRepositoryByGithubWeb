using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Model;

namespace DataAccess
{
    public class DestinationConfiguration 
        : EntityTypeConfiguration<Destination>
    {
        public DestinationConfiguration()
        {
            Property(d => d.Name).IsRequired();
            Property(d => d.Description).HasMaxLength(500);
            Property(d => d.Phto).HasColumnType("image");
        }
    }

    public class LodgingConfiguration
        : EntityTypeConfiguration<Lodging>
    {
        public LodgingConfiguration()
        {
            Property(d => d.Name).IsRequired().HasMaxLength(500);
        }
    }

    public class TripConfiguration
      : EntityTypeConfiguration<Trip>
    {
        public TripConfiguration()
        {
            HasKey(t => t.Identifier);
        }
    }
}
