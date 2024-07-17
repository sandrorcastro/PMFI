using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TipoLicitacao
    {
        public TipoLicitacao()
        {
            ContratoConcessaos = new HashSet<ContratoConcessao>();
        }

        public int TplId { get; set; }
        public string? TplDescricao { get; set; }
        public string TplPadraoTce { get; set; } = null!;

        public virtual ICollection<ContratoConcessao> ContratoConcessaos { get; set; }
    }
}
