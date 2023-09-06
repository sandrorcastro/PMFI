using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class AlmoxarifLote
    {
        public AlmoxarifLote()
        {
            AlmEntradaItens = new HashSet<AlmEntradaIten>();
            AlmSaidasItens = new HashSet<AlmSaidasIten>();
        }

        public long AlmoxId { get; set; }
        public long ItemId { get; set; }
        public long LoteId { get; set; }
        public decimal? AlmLotQtdeEntrada { get; set; }
        public decimal? AlmLotQtdeSaida { get; set; }

        public virtual Almoxarifado Almox { get; set; } = null!;
        public virtual AlmIten Item { get; set; } = null!;
        public virtual AlmLote Lote { get; set; } = null!;
        public virtual ICollection<AlmEntradaIten> AlmEntradaItens { get; set; }
        public virtual ICollection<AlmSaidasIten> AlmSaidasItens { get; set; }
    }
}
