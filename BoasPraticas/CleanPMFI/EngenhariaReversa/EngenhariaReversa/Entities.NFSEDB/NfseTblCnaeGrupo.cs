using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblCnaeGrupo
    {
        public string IdcnaeGrupo { get; set; } = null!;
        public string? IdcnaeDivisao { get; set; }
        public string? Stdescricao { get; set; }
    }
}
