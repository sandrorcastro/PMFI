using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class AlmoxarifIten
    {
        public AlmoxarifIten()
        {
            AlmEntradaItens = new HashSet<AlmEntradaIten>();
            AlmRequisicoesItens = new HashSet<AlmRequisicoesIten>();
            AlmSaidasItens = new HashSet<AlmSaidasIten>();
        }

        public long AlmoxId { get; set; }
        public long ItemId { get; set; }
        public decimal? QtdeEntrada { get; set; }
        public decimal? QtdeSaida { get; set; }
        public decimal? QtdeReservada { get; set; }
        public decimal? EstoqueMin { get; set; }
        public decimal? EstoqueMax { get; set; }

        public virtual Almoxarifado Almox { get; set; } = null!;
        public virtual AlmIten Item { get; set; } = null!;
        public virtual ICollection<AlmEntradaIten> AlmEntradaItens { get; set; }
        public virtual ICollection<AlmRequisicoesIten> AlmRequisicoesItens { get; set; }
        public virtual ICollection<AlmSaidasIten> AlmSaidasItens { get; set; }
    }
}
