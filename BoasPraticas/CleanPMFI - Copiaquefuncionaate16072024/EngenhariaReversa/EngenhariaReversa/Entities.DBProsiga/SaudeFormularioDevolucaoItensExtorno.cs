using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class SaudeFormularioDevolucaoItensExtorno
    {
        public long IdItemExtorno { get; set; }
        public long? IdFormulario { get; set; }
        public string? IdLote { get; set; }
        public long? IdFabricante { get; set; }
        public long? IdMedicamento { get; set; }
        public long? IdAlmox { get; set; }
        public long? Qtd { get; set; }
        public long? SaldoLote { get; set; }
        public int? SaldoMedicamento { get; set; }
        public DateTime? DtMovimento { get; set; }
        public string? HoraMovimento { get; set; }
        public string? Usuario { get; set; }

        public virtual SaudeFormularioDevolucao? IdFormularioNavigation { get; set; }
    }
}
