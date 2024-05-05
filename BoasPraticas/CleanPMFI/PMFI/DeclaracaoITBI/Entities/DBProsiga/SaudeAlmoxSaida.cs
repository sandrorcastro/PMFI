using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SaudeAlmoxSaida
{
    public long IdSaida { get; set; }

    public DateTime? DataSaida { get; set; }

    public string? HoraSaida { get; set; }

    public long? IdRequisicao { get; set; }

    public long? IdAlmox { get; set; }

    public long? IdEstoque { get; set; }

    public string? Removido { get; set; }

    public long? Idpaciente { get; set; }

    public long? Idreceita { get; set; }

    public virtual ICollection<SaudeAlmoxSaidaItemExtorno> SaudeAlmoxSaidaItemExtornos { get; set; } = new List<SaudeAlmoxSaidaItemExtorno>();

    public virtual ICollection<SaudeAlmoxSaidasItem> SaudeAlmoxSaidasItems { get; set; } = new List<SaudeAlmoxSaidasItem>();
}
