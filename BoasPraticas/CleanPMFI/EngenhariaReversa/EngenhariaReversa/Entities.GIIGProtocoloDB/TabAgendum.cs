using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabAgendum
    {
        public int AgenId { get; set; }
        public int TpAgId { get; set; }
        public int? PessId { get; set; }
        public int? AgenSequencia { get; set; }
        public DateTime? AgenData { get; set; }
        public string? AgenTipo { get; set; }
        public bool? AgenAtendido { get; set; }
        public string? AgenHora { get; set; }

        public virtual TabPessoa? Pess { get; set; }
        public virtual TabTipoAgendum TpAg { get; set; } = null!;
    }
}
