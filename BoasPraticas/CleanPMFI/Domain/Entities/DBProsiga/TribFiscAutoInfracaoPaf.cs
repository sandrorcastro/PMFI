using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribFiscAutoInfracaoPaf
    {
        public TribFiscAutoInfracaoPaf()
        {
            TribFiscAutoInfracaoPafobjetos = new HashSet<TribFiscAutoInfracaoPafobjeto>();
        }

        public int Pafid { get; set; }
        public byte? Pafinstancia { get; set; }
        public int AutoId { get; set; }
        public string? Pafparecer { get; set; }
        public string? Pafsituacao { get; set; }
        public int? ProtId { get; set; }

        public virtual TribFiscAutoInfraco Auto { get; set; } = null!;
        public virtual ICollection<TribFiscAutoInfracaoPafobjeto> TribFiscAutoInfracaoPafobjetos { get; set; }
    }
}
