using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblDeclaracaoExtravioNfse
    {
        public int Iddecextravio { get; set; }
        public long Idnfse { get; set; }

        public virtual NfseTblDeclaracaoExtravio IddecextravioNavigation { get; set; } = null!;
        public virtual NfseTblNfse IdnfseNavigation { get; set; } = null!;
    }
}
