using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class SaudeFarmaEntradasItemFormulario
    {
        public long IdEntradaItem { get; set; }
        public long IdEntrada { get; set; }
        public long IdEstoque { get; set; }
        public long IdFabricante { get; set; }
        public string IdLote { get; set; } = null!;
        public long IdMedicamento { get; set; }
        public long? Quant { get; set; }
        public long? SaldoLote { get; set; }
        public string? Removido { get; set; }
        public long? SaldoMedicamento { get; set; }
        public long? IdSaidaItem { get; set; }
        public string? Status { get; set; }
        public DateTime? DtMovimento { get; set; }
        public string? HrMovimento { get; set; }

        public virtual SaudeFarmaEntradasPorFormulario IdEntradaNavigation { get; set; } = null!;
    }
}
