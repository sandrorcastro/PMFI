using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class DesifDemonstrativoPartidasLancamentosContabei
    {
        public int Iddemparlancon { get; set; }
        public string Stcnpjcontab { get; set; } = null!;
        public int Idcidadecontab { get; set; }
        public string Idlancamento { get; set; } = null!;
        public DateTime Dtlancamento { get; set; }
        public decimal Vlparlancamento { get; set; }
        public string Stsubtitulo { get; set; } = null!;
        public byte Nutipopartida { get; set; }
        public byte? Idcodigoevento { get; set; }
        public int? Idcidadevinculo { get; set; }
        public string Sthistpartida { get; set; } = null!;
    }
}
