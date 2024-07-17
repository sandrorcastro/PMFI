using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblEmpresaPerfilHistorico
    {
        public int Idempperhis { get; set; }
        public int Idperfil { get; set; }
        public byte[] Imlogo { get; set; } = null!;
        public DateTime Dtdata { get; set; }
    }
}
