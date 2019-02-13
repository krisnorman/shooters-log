using System;
using System.Collections.Generic;
using System.Text;

namespace ShootersLog.Data.EntityFramework.Entities
{
    public class Cartridge
    {
        public int Id { get; set; }
        public CartridgeType Type { get; set; }
        public int CaliberId { get; set; }
        public virtual Caliber Caliber { get; set; }
        public string Name { get; set; }
    }
}
