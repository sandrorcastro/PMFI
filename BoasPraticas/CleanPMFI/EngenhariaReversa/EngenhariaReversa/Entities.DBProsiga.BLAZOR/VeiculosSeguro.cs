using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class VeiculosSeguro
    {
        public long VeiculoId { get; set; }
        public long SeguroId { get; set; }
        public decimal? Valor { get; set; }

        public virtual Seguro Seguro { get; set; } = null!;
        public virtual Veiculo Veiculo { get; set; } = null!;
    }
}
