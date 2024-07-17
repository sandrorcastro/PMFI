using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblNfsePrestador
    {
        public long Idnfse { get; set; }
        public string? Stim { get; set; }
        public string StrazaoSocial { get; set; } = null!;
        public string? StnomeFantasia { get; set; }
        public string Stcpfcnpj { get; set; } = null!;
        public string Stendereco { get; set; } = null!;
        public string Stnumero { get; set; } = null!;
        public string? Stcomplemento { get; set; }
        public string Stbairro { get; set; } = null!;
        public int NucidadeIbge { get; set; }
        public string Stuf { get; set; } = null!;
        public string Stcep { get; set; } = null!;
        public string Stemail { get; set; } = null!;
        public string? Sttelefone { get; set; }

        public virtual NfseTblNfse IdnfseNavigation { get; set; } = null!;
    }
}
