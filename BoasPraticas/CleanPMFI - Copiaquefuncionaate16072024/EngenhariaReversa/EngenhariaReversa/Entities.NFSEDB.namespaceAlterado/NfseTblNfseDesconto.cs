using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblNfseDesconto
    {
        public long Idnfse { get; set; }
        public int Idtipodesconto { get; set; }
        public decimal Vldesconto { get; set; }
        public string? Streferencia { get; set; }
        public decimal? Vlcamporeferente { get; set; }

        public virtual NfseTblNfse IdnfseNavigation { get; set; } = null!;
        public virtual NfseTblTipoDesconto IdtipodescontoNavigation { get; set; } = null!;
    }
}
