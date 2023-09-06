using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabAtributoMovimento
    {
        public int AtriId { get; set; }
        public long MoviId { get; set; }
        public string? AtmvValor { get; set; }

        public virtual TabAtributo Atri { get; set; } = null!;
        public virtual TabMovimento Movi { get; set; } = null!;
    }
}
