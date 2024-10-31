using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SaudeFormularioDevolucao
    {
        public SaudeFormularioDevolucao()
        {
            SaudeFormularioDevolucaoItens = new HashSet<SaudeFormularioDevolucaoIten>();
            SaudeFormularioDevolucaoItensExtornos = new HashSet<SaudeFormularioDevolucaoItensExtorno>();
        }

        public long IdFormulario { get; set; }
        public DateTime? DataMov { get; set; }
        public string? HoraMov { get; set; }
        public long? IdTipoMov { get; set; }
        public long? IdAlmoxSaida { get; set; }
        public long? IdEstoqueSaida { get; set; }
        public long? IdAlmoxDestino { get; set; }
        public long? IdFornecedor { get; set; }

        public virtual ICollection<SaudeFormularioDevolucaoIten> SaudeFormularioDevolucaoItens { get; set; }
        public virtual ICollection<SaudeFormularioDevolucaoItensExtorno> SaudeFormularioDevolucaoItensExtornos { get; set; }
    }
}
