using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Assunto
{
    public int IdAssunto { get; set; }

    public string CodigoEstruturado { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public string? Observacao { get; set; }

    public string? IdxAssunto { get; set; }

    public string SinAtivo { get; set; } = null!;

    public int? PrazoIntermediario { get; set; }

    public int? PrazoCorrente { get; set; }

    public string? StaDestinacao { get; set; }

    public string? SinEstrutural { get; set; }

    public int IdTabelaAssuntos { get; set; }

    public virtual ICollection<AssuntoProxy> AssuntoProxies { get; set; } = new List<AssuntoProxy>();

    public virtual ICollection<AvaliacaoDocumental> AvaliacaoDocumentals { get; set; } = new List<AvaliacaoDocumental>();

    public virtual TabelaAssunto IdTabelaAssuntosNavigation { get; set; } = null!;

    public virtual ICollection<Assunto> IdAssuntoDestinos { get; set; } = new List<Assunto>();

    public virtual ICollection<Assunto> IdAssuntoOrigems { get; set; } = new List<Assunto>();
}
