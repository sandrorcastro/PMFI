using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class DesifEventosContabeisContasResultado
    {
        public byte Idcodigoevento { get; set; }
        public string Stdescricao { get; set; } = null!;
        public int? Idtipoevento { get; set; }
    }
}
