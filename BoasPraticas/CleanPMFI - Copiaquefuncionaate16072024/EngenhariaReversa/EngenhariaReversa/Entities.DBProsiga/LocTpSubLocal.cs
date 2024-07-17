using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class LocTpSubLocal
    {
        public LocTpSubLocal()
        {
            LocSubLocals = new HashSet<LocSubLocal>();
        }

        public int TipoSubLocId { get; set; }
        public string? TsnmTipo { get; set; }
        public string? TstecUltAlt { get; set; }
        public DateTime? TsdtUltAlt { get; set; }

        public virtual ICollection<LocSubLocal> LocSubLocals { get; set; }
    }
}
