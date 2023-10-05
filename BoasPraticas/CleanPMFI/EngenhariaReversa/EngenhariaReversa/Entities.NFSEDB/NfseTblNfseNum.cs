using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblNfseNum
    {
        public int Idempresa { get; set; }
        public int Nunumero { get; set; }
        public int Nuano { get; set; }

        public virtual NfseTblEmpresa IdempresaNavigation { get; set; } = null!;
    }
}
