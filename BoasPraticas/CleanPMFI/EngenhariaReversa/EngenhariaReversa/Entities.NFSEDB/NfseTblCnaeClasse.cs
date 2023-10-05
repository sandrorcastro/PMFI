using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblCnaeClasse
    {
        public string IdcnaeClasse { get; set; } = null!;
        public string? IdcnaeGrupo { get; set; }
        public string? Stdescricao { get; set; }
    }
}
