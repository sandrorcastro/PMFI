using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblEmpresaSubstitutoHistorico
    {
        public long Idalteracao { get; set; }
        public int Idempresa { get; set; }
        public DateTime Dtentrada { get; set; }
        public DateTime? Dtsaida { get; set; }
        public bool? Issubstituto { get; set; }

        public virtual NfseTblEmpresa IdempresaNavigation { get; set; } = null!;
    }
}
