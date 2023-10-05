using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblEmpresaContratosHomologacao
    {
        public int Idempconthomo { get; set; }
        public int Idempcont { get; set; }
        public DateTime? Dtexecucaoini { get; set; }
        public DateTime? Dtexecucaofim { get; set; }
        public decimal? Vlservico { get; set; }
        public string Sttipo { get; set; } = null!;
        public string Idusuariosolicitou { get; set; } = null!;
        public string? Idusuarioavaliou { get; set; }
        public DateTime Dtsolicitacao { get; set; }
        public DateTime? Dtavaliacao { get; set; }
        public string Stsituacao { get; set; } = null!;
        public string? Stparecer { get; set; }
        public byte Nutipovigencia { get; set; }

        public virtual NfseTblUsuario IdusuariosolicitouNavigation { get; set; } = null!;
    }
}
