using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblEncerramentoBoleto
    {
        public int Idencerramento { get; set; }
        public string Bolenossonumero { get; set; } = null!;
        public string Stsituacao { get; set; } = null!;
        public DateTime Dtimpressao { get; set; }
        public DateTime Dtvencimento { get; set; }
        public decimal Vltotal { get; set; }
        public DateTime? Dtcancelamento { get; set; }
        public string? Dsmotcancelamento { get; set; }

        public virtual NfseTblEncerramento IdencerramentoNavigation { get; set; } = null!;
    }
}
