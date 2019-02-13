using System;
using System.Collections.Generic;
using System.Text;

namespace ShootersLog.Data.EntityFramework.Entities
{
    public class Caliber
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CaliberSpecId { get; set; }
        public virtual CaliberSpec Spec { get; set; }
    }
}
