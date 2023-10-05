using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblEcfLacre
    {
        public int Idlacre { get; set; }
        public int Idecfint { get; set; }
        public int Idtipolacre { get; set; }
        public string Stlacreremov { get; set; } = null!;
        public string Stlacrecoloc { get; set; } = null!;
        public DateTime Dtdata { get; set; }
    }
}
