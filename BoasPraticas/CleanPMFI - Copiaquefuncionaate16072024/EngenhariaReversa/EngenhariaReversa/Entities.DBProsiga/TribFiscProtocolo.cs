using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribFiscProtocolo
    {
        public TribFiscProtocolo()
        {
            Recs = new HashSet<TribFiscReceitum>();
        }

        public int ProtId { get; set; }
        public DateTime? Data { get; set; }
        public string? Operacao { get; set; }

        public virtual ICollection<TribFiscReceitum> Recs { get; set; }
    }
}
