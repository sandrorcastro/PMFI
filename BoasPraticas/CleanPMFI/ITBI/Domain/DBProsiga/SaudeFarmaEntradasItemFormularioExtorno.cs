using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SaudeFarmaEntradasItemFormularioExtorno
    {
        public long IdEntradaItemExtorno { get; set; }
        public long IdEntrada { get; set; }
        public long IdEstoque { get; set; }
        public long IdFabricante { get; set; }
        public string IdLote { get; set; } = null!;
        public long IdMedicamento { get; set; }
        public long? Quant { get; set; }
        public long? SaldoLote { get; set; }
        public long? SaldoMedicamento { get; set; }
        public long? IdSaidaItem { get; set; }
        public DateTime? DtMovimento { get; set; }
        public string? HrMovimento { get; set; }
        public string? Usuario { get; set; }

        public virtual SaudeFarmaEntradasPorFormulario IdEntradaNavigation { get; set; } = null!;
    }
}
