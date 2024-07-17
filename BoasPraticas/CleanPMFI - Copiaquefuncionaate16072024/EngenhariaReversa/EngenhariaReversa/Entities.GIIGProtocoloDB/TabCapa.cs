using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabCapa
    {
        public int Id { get; set; }
        public string TextoDescritivo { get; set; } = null!;
        public string NomeRelatorio { get; set; } = null!;
        public bool FlAtiva { get; set; }
        public short AssuId { get; set; }

        public virtual TabAssunto Assu { get; set; } = null!;
    }
}
