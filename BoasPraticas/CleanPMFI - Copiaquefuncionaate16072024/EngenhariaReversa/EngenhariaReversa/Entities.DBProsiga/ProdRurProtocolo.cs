using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class ProdRurProtocolo
    {
        public ProdRurProtocolo()
        {
            IdnotaFiscals = new HashSet<ProdRurNotaFiscal>();
        }

        public int Idprotocolo { get; set; }
        public DateTime? Data { get; set; }
        public string? Operacao { get; set; }

        public virtual ICollection<ProdRurNotaFiscal> IdnotaFiscals { get; set; }
    }
}
