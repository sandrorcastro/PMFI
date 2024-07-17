using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblEmpresaCnae
    {
        public int Idempresa { get; set; }
        public string IdcnaeSubclasse { get; set; } = null!;
        public DateTime? DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }

        public virtual NfseTblCnaeSubclasse IdcnaeSubclasseNavigation { get; set; } = null!;
        public virtual NfseTblEmpresa IdempresaNavigation { get; set; } = null!;
    }
}
