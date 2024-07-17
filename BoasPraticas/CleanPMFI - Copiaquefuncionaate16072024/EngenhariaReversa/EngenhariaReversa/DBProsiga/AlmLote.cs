using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class AlmLote
    {
        public AlmLote()
        {
            AlmEntradaItens = new HashSet<AlmEntradaIten>();
            AlmoxarifLotes = new HashSet<AlmoxarifLote>();
        }

        public long LoteId { get; set; }
        public string? LoteNum { get; set; }
        public DateTime LotDtFabric { get; set; }
        public DateTime? LotDtVenc { get; set; }
        public string? LotObserv { get; set; }

        public virtual ICollection<AlmEntradaIten> AlmEntradaItens { get; set; }
        public virtual ICollection<AlmoxarifLote> AlmoxarifLotes { get; set; }
    }
}
