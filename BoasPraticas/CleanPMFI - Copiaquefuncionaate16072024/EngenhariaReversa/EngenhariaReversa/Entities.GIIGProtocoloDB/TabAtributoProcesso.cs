using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabAtributoProcesso
    {
        public int AtriId { get; set; }
        public long ProcId { get; set; }
        public string? AtprValor { get; set; }

        public virtual TabAtributo Atri { get; set; } = null!;
        public virtual TabProcesso Proc { get; set; } = null!;
    }
}
