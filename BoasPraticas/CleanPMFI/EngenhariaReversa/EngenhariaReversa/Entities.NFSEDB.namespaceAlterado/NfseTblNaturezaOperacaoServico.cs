using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblNaturezaOperacaoServico
    {
        public byte Idoperacao { get; set; }
        public string Idservico { get; set; } = null!;

        public virtual NfseTblServico IdservicoNavigation { get; set; } = null!;
    }
}
