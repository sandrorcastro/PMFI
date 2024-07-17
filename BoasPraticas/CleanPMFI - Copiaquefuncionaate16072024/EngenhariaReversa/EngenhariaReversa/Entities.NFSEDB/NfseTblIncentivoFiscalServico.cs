using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblIncentivoFiscalServico
    {
        public short Idincentivo { get; set; }
        public string Idservico { get; set; } = null!;
        public decimal? Staliquota { get; set; }
    }
}
