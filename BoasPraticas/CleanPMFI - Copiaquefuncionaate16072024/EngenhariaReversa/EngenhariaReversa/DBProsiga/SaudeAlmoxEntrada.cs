using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SaudeAlmoxEntrada
    {
        public SaudeAlmoxEntrada()
        {
            SaudeAlmoxEntradasItems = new HashSet<SaudeAlmoxEntradasItem>();
            SaudeAlmoxEntradasItensExtornos = new HashSet<SaudeAlmoxEntradasItensExtorno>();
        }

        public int IdAmoxEntrada { get; set; }
        public int IdAlmoxarifado { get; set; }
        public string? NrNotaFiscal { get; set; }
        public DateTime DtNotaFiscal { get; set; }
        public string? NrEmpenho { get; set; }
        public DateTime? DtEmpenho { get; set; }
        public DateTime DtMovimento { get; set; }
        public string? HrMovimento { get; set; }
        public int IdtipoMovimentacao { get; set; }
        public int? IdFornecedor { get; set; }
        public int? IdEstoqueDevolucao { get; set; }
        public int? IdAlmoxDevolucao { get; set; }
        public string? NrDocumentoDevolucao { get; set; }
        public long? IdFormulario { get; set; }
        public int? Removido { get; set; }
        public string? Status { get; set; }

        public virtual ICollection<SaudeAlmoxEntradasItem> SaudeAlmoxEntradasItems { get; set; }
        public virtual ICollection<SaudeAlmoxEntradasItensExtorno> SaudeAlmoxEntradasItensExtornos { get; set; }
    }
}
