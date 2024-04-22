using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribLegislacaoComponente
    {
        public TribLegislacaoComponente()
        {
            InverseTipoComp = new HashSet<TribLegislacaoComponente>();
            ItemVists = new HashSet<TribFiscItensVistorium>();
            Leis = new HashSet<TribLegislacao>();
        }

        public int LeiCompId { get; set; }
        public int? TipoCompId { get; set; }
        public string? LeiCompTexto { get; set; }
        public string? LeiCompNumero { get; set; }
        public int? LeiCompIdref { get; set; }

        public virtual TribLegislacaoComponente? TipoComp { get; set; }
        public virtual ICollection<TribLegislacaoComponente> InverseTipoComp { get; set; }

        public virtual ICollection<TribFiscItensVistorium> ItemVists { get; set; }
        public virtual ICollection<TribLegislacao> Leis { get; set; }
    }
}
