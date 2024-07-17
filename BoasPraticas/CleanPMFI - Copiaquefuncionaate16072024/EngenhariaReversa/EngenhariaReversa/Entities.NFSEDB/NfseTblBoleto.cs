using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblBoleto
    {
        public string Stnossonumero { get; set; } = null!;
        public DateTime? Dtvencimento { get; set; }
        public decimal? Vltotal { get; set; }
        public DateTime? Dtemissao { get; set; }
        public string? Stlinhadigitavel { get; set; }
        public string? Stcodigobarra { get; set; }
    }
}
