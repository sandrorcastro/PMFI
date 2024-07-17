using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class DesifCodigosTributacaoMunicipio
    {
        public int Idcodtribmuni { get; set; }
        public int Idcidade { get; set; }
        public string Stcodtribdesif { get; set; } = null!;
        public decimal Nualiquota { get; set; }
        public DateTime Dtinivigencia { get; set; }
        public DateTime? Dtfimvigencia { get; set; }
    }
}
