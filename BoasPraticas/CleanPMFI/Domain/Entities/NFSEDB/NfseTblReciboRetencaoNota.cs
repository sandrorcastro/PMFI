using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblReciboRetencaoNota
    {
        public int Idrecibo { get; set; }
        public long Idnfse { get; set; }

        public virtual NfseTblNfse IdnfseNavigation { get; set; } = null!;
        public virtual NfseTblReciboRetencao IdreciboNavigation { get; set; } = null!;
    }
}
