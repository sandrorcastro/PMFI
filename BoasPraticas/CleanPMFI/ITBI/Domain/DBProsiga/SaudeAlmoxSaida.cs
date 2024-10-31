using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SaudeAlmoxSaida
    {
        public SaudeAlmoxSaida()
        {
            SaudeAlmoxSaidaItemExtornos = new HashSet<SaudeAlmoxSaidaItemExtorno>();
            SaudeAlmoxSaidasItems = new HashSet<SaudeAlmoxSaidasItem>();
        }

        public long IdSaida { get; set; }
        public DateTime? DataSaida { get; set; }
        public string? HoraSaida { get; set; }
        public long? IdRequisicao { get; set; }
        public long? IdAlmox { get; set; }
        public long? IdEstoque { get; set; }
        public string? Removido { get; set; }
        public long? Idpaciente { get; set; }
        public long? Idreceita { get; set; }

        public virtual ICollection<SaudeAlmoxSaidaItemExtorno> SaudeAlmoxSaidaItemExtornos { get; set; }
        public virtual ICollection<SaudeAlmoxSaidasItem> SaudeAlmoxSaidasItems { get; set; }
    }
}
