using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class FissSituacaoRec
    {
        public FissSituacaoRec()
        {
            FissDocFiscais = new HashSet<FissDocFiscai>();
        }

        public int SitRecId { get; set; }
        public string? SitRecNome { get; set; }
        public string? SitRecNotaEmitida { get; set; }
        public string? SitRecNotaRecebida { get; set; }
        public string? SitRecSubstituto { get; set; }

        public virtual ICollection<FissDocFiscai> FissDocFiscais { get; set; }
    }
}
