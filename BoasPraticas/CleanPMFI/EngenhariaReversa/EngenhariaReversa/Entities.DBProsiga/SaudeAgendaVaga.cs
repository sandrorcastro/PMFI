using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class SaudeAgendaVaga
    {
        public long Idagenda { get; set; }
        public int IdUnidadeSaude { get; set; }
        public int? NroVagas { get; set; }
        public int? NroVagasUsadas { get; set; }

        public virtual UnidadeSaude IdUnidadeSaudeNavigation { get; set; } = null!;
        public virtual SaudeAgendaXxxxxx IdagendaNavigation { get; set; } = null!;
    }
}
