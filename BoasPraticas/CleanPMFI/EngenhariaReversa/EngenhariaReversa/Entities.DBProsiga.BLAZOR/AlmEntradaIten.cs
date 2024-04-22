using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class AlmEntradaIten
    {
        public long EntrItemId { get; set; }
        public long? EntrId { get; set; }
        public long? AlmoxId { get; set; }
        public long? ItemId { get; set; }
        public long? LoteId { get; set; }
        public decimal? EntrItQtde { get; set; }
        public decimal? EntrItVlrTotal { get; set; }

        public virtual AlmoxarifIten? AlmoxarifIten { get; set; }
        public virtual AlmoxarifLote? AlmoxarifLote { get; set; }
        public virtual AlmEntrada? Entr { get; set; }
        public virtual AlmIten? Item { get; set; }
        public virtual AlmLote? Lote { get; set; }
    }
}
