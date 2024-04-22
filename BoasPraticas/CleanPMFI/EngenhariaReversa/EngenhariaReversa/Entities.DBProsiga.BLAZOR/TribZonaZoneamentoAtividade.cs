using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribZonaZoneamentoAtividade
    {
        public short ZozoId { get; set; }
        public string Atividade { get; set; } = null!;
        public short ZotlId { get; set; }

        public virtual TribAtivAtividade AtividadeNavigation { get; set; } = null!;
        public virtual TribZonaTipoLiberacao Zotl { get; set; } = null!;
        public virtual TribZonaZoneamento Zozo { get; set; } = null!;
    }
}
