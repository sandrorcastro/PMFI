using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblEmpresaServicoNaturezaOperacao
    {
        public int Idempresa { get; set; }
        public string Idservico { get; set; } = null!;
        public byte Idoperacao { get; set; }

        public virtual NfseTblEmpresa IdempresaNavigation { get; set; } = null!;
        public virtual NfseTblNaturezaOperacao IdoperacaoNavigation { get; set; } = null!;
        public virtual NfseTblServico IdservicoNavigation { get; set; } = null!;
    }
}
