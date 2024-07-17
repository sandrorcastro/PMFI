using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblDeclaracaoSemIncidenciaNfse
    {
        public int? Iddeclaracao { get; set; }
        public long? Idnfse { get; set; }

        public virtual NfseTblDeclaracaoSemIncidencium? IddeclaracaoNavigation { get; set; }
        public virtual NfseTblNfse? IdnfseNavigation { get; set; }
    }
}
