using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SaudeAlmoxEntradaDevolucao
    {
        public long IdFormularioDevolucao { get; set; }
        public long? DataFormulario { get; set; }
        public DateTime? DataRecebimento { get; set; }
        public string? HoraRecebimento { get; set; }
        public long? IdAlmoxOrigem { get; set; }
        public long? IdEstoqueOrigem { get; set; }
        public long? IdAlmoxDestino { get; set; }
    }
}
