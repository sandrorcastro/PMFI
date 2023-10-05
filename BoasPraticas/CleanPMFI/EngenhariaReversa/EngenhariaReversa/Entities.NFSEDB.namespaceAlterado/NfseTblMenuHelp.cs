using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblMenuHelp
    {
        public NfseTblMenuHelp()
        {
            NfseTblFormHelps = new HashSet<NfseTblFormHelp>();
        }

        public int Idmenu { get; set; }
        public string? NmMenu { get; set; }
        public string? NmForm { get; set; }

        public virtual ICollection<NfseTblFormHelp> NfseTblFormHelps { get; set; }
    }
}
