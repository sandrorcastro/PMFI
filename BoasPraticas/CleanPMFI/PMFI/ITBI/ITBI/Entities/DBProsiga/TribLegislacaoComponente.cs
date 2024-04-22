using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribLegislacaoComponente
{
    public int LeiCompId { get; set; }

    public int? TipoCompId { get; set; }

    public string? LeiCompTexto { get; set; }

    public string? LeiCompNumero { get; set; }

    public int? LeiCompIdref { get; set; }

    public virtual ICollection<TribLegislacaoComponente> InverseTipoComp { get; set; } = new List<TribLegislacaoComponente>();

    public virtual TribLegislacaoComponente? TipoComp { get; set; }

    public virtual ICollection<TribFiscItensVistorium> ItemVists { get; set; } = new List<TribFiscItensVistorium>();

    public virtual ICollection<TribLegislacao> Leis { get; set; } = new List<TribLegislacao>();
}
