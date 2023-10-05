using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblCnaeDivisao
    {
        public string IdcnaeDivisao { get; set; } = null!;
        public string IdcnaeSecao { get; set; } = null!;
        public string? Stdescricao { get; set; }
    }
}
