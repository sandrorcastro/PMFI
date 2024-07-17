using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblEmpresaNaturezaOperaco
    {
        public int Idempresa { get; set; }
        public byte Idoperacao { get; set; }

        public virtual NfseTblEmpresa IdempresaNavigation { get; set; } = null!;
    }
}
