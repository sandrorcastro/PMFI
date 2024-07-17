using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblRpssub
    {
        public long Idnfse { get; set; }
        public long Idnfsesub { get; set; }
        public long Numero { get; set; }
        public string Serie { get; set; } = null!;
        public int Tipo { get; set; }
        public long RpsNumeprot { get; set; }

        public virtual NfseTblNfse IdnfseNavigation { get; set; } = null!;
    }
}
