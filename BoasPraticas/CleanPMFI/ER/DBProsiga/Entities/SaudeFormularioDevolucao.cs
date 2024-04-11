using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SaudeFormularioDevolucao
{
    public long IdFormulario { get; set; }

    public DateTime? DataMov { get; set; }

    public string? HoraMov { get; set; }

    public long? IdTipoMov { get; set; }

    public long? IdAlmoxSaida { get; set; }

    public long? IdEstoqueSaida { get; set; }

    public long? IdAlmoxDestino { get; set; }

    public long? IdFornecedor { get; set; }

    public virtual ICollection<SaudeFormularioDevolucaoIten> SaudeFormularioDevolucaoItens { get; set; } = new List<SaudeFormularioDevolucaoIten>();

    public virtual ICollection<SaudeFormularioDevolucaoItensExtorno> SaudeFormularioDevolucaoItensExtornos { get; set; } = new List<SaudeFormularioDevolucaoItensExtorno>();
}
