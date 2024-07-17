using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblEncerramentoConta
    {
        public int Idencerramento { get; set; }
        public int Idconta { get; set; }

        public virtual NfseTblContum IdcontaNavigation { get; set; } = null!;
        public virtual NfseTblEncerramento IdencerramentoNavigation { get; set; } = null!;
    }
}
