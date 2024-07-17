using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class FissSerieNotasFiscai
    {
        public FissSerieNotasFiscai()
        {
            FissDocFiscais = new HashSet<FissDocFiscai>();
        }

        public int SerieId { get; set; }
        public string? SerieNome { get; set; }
        public string? SerieNotaEmitida { get; set; }
        public string? SerieNotaRecebida { get; set; }

        public virtual ICollection<FissDocFiscai> FissDocFiscais { get; set; }
    }
}
