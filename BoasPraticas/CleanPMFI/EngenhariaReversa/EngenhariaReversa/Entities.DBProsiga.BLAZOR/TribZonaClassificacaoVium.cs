using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribZonaClassificacaoVium
    {
        public TribZonaClassificacaoVium()
        {
            TribQuadraLograds = new HashSet<TribQuadraLograd>();
        }

        public int ClViId { get; set; }
        public string? ClViClassificacao { get; set; }
        public string? ClViDescricao { get; set; }
        public string? ClViCorMapa { get; set; }

        public virtual ICollection<TribQuadraLograd> TribQuadraLograds { get; set; }
    }
}
