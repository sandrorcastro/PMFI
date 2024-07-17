using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblPedIncluirServico
    {
        public int Idpedido { get; set; }
        public int Idempresa { get; set; }
        public string Stobservacao { get; set; } = null!;
        public DateTime Dtpedido { get; set; }
        public DateTime? Dtparecer { get; set; }
        public string? Stparecer { get; set; }
        public string? Stfiscal { get; set; }
        public string Idusuario { get; set; } = null!;
        public string Stsituacao { get; set; } = null!;
    }
}
