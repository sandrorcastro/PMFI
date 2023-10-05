using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblRpsImpresso
    {
        public long Idrpsimpresso { get; set; }
        public long Idnfse { get; set; }
        public int Idempresa { get; set; }
        public string Nunumero { get; set; } = null!;
        public string? Stserie { get; set; }
        public string? Sttipo { get; set; }
        public DateTime? Dtemissao { get; set; }

        public virtual NfseTblEmpresa IdempresaNavigation { get; set; } = null!;
        public virtual NfseTblNfse IdnfseNavigation { get; set; } = null!;
    }
}
