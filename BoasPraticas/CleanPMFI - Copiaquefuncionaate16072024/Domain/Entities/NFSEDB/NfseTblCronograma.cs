using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblCronograma
    {
        public short Idcronograma { get; set; }
        public string Stdescricao { get; set; } = null!;
        public DateTime Dtdata { get; set; }
    }
}
