using ShootersLog.Data.EntityFramework.Entities;
using System;
using System.Data.Entity;

namespace ShootersLog.Data.EntityFramework
{
    public class ShootersLogContext : DbContext
    {
        public virtual DbSet<Cartridge> Cartridges { get; set; }
        public virtual DbSet<Caliber> Calibers { get; set; }
        public virtual DbSet<CaliberSpec> CaliberSpecs { get; set; }
    }
}
