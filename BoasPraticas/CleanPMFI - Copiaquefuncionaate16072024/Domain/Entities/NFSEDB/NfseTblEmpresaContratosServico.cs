using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblEmpresaContratosServico
    {
        public int Idempcont { get; set; }
        public string Idservico { get; set; } = null!;
        public string? Stpermite { get; set; }
        public string? IdcnaeSubclasse { get; set; }

        public virtual NfseTblEmpresaContrato IdempcontNavigation { get; set; } = null!;
        public virtual NfseTblServico IdservicoNavigation { get; set; } = null!;
    }
}
