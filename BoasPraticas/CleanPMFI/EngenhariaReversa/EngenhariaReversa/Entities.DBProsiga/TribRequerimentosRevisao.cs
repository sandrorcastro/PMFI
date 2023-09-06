using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribRequerimentosRevisao
    {
        public TribRequerimentosRevisao()
        {
            TribRequerimentoRevisaoImoveis = new HashSet<TribRequerimentoRevisaoImovei>();
        }

        public long ReqRevId { get; set; }
        public DateTime? ReqRevData { get; set; }
        public int? ReqRevAnoProtoc { get; set; }
        public int? ReqRevNumProtoc { get; set; }
        public string? ReqRevNome { get; set; }

        public virtual ICollection<TribRequerimentoRevisaoImovei> TribRequerimentoRevisaoImoveis { get; set; }
    }
}
