using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblEmpresaServico
    {
        public int Idempresa { get; set; }
        public string Idservico { get; set; } = null!;
        public DateTime? DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }

        public virtual NfseTblEmpresa IdempresaNavigation { get; set; } = null!;
        public virtual NfseTblServico IdservicoNavigation { get; set; } = null!;
    }
}
