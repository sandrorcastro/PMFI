using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblContaSocio
    {
        public int Idconta { get; set; }
        public int Idempresasocio { get; set; }

        public virtual NfseTblContum IdcontaNavigation { get; set; } = null!;
        public virtual NfseTblEmpresa IdempresasocioNavigation { get; set; } = null!;
    }
}
