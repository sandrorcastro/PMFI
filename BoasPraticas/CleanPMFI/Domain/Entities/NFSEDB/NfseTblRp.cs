using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblRp
    {
        public long Idnfse { get; set; }
        public long Numero { get; set; }
        public string Serie { get; set; } = null!;
        public int Tipo { get; set; }
        public long RpsNumeprot { get; set; }
        public DateTime Dtemissao { get; set; }

        public virtual NfseTblNfse IdnfseNavigation { get; set; } = null!;
    }
}
