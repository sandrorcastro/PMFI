using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblCronogramaServico
    {
        public short Idcronograma { get; set; }
        public string Idservico { get; set; } = null!;

        public virtual NfseTblCronograma IdcronogramaNavigation { get; set; } = null!;
        public virtual NfseTblServico IdservicoNavigation { get; set; } = null!;
    }
}
