using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblPedServicosIncluso
    {
        public int Idpedido { get; set; }
        public string Idservico { get; set; } = null!;
    }
}
