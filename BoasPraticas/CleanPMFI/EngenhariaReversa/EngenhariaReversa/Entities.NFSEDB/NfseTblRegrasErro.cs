using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblRegrasErro
    {
        public int Iderro { get; set; }
        public string Sterro { get; set; } = null!;
        public string Stnfse { get; set; } = null!;
        public DateTime Dterro { get; set; }
        public int Idregra { get; set; }

        public virtual NfseTblRegra IdregraNavigation { get; set; } = null!;
    }
}
