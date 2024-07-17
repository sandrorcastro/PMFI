using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class DesifDemonstrativoRateioResultadosInterno
    {
        public int Iddemratrec { get; set; }
        public int Iddeclaracao { get; set; }
        public string Stcoddepende { get; set; } = null!;
        public DateTime Dtcompetencia { get; set; }
        public string Stdescrateio { get; set; } = null!;
        public decimal Vlrateio { get; set; }
        public byte Nutipopartida { get; set; }
        public byte Idcodigoevento { get; set; }
    }
}
