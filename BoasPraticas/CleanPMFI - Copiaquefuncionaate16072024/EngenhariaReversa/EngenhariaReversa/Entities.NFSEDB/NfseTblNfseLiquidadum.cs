using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblNfseLiquidadum
    {
        public long Idnfse { get; set; }
        public int Idliquidacao { get; set; }

        public virtual NfseTblNfse IdnfseNavigation { get; set; } = null!;
    }
}
