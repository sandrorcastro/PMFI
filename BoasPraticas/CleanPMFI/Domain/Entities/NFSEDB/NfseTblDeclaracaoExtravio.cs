using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblDeclaracaoExtravio
    {
        public int Iddecextravio { get; set; }
        public int Idcontribuinte { get; set; }
        public DateTime Dtemissao { get; set; }
        public string? Stobservacoes { get; set; }
        public DateTime Dtextravio { get; set; }
        public byte[]? Barquivocompr { get; set; }
        public byte Idtipodec { get; set; }
        public string? Stnmarquivo { get; set; }
        public DateTime? Dtcomprovante { get; set; }

        public virtual NfseTblContribuinte IdcontribuinteNavigation { get; set; } = null!;
    }
}
