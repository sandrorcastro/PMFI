using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class SecaoModelo
{
    public int IdSecaoModelo { get; set; }

    public int IdModelo { get; set; }

    public string Nome { get; set; } = null!;

    public string? Conteudo { get; set; }

    public int Ordem { get; set; }

    public string SinSomenteLeitura { get; set; } = null!;

    public string SinAssinatura { get; set; } = null!;

    public string SinPrincipal { get; set; } = null!;

    public string SinDinamica { get; set; } = null!;

    public string SinCabecalho { get; set; } = null!;

    public string SinRodape { get; set; } = null!;

    public string SinHtml { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public virtual Modelo IdModeloNavigation { get; set; } = null!;

    public virtual ICollection<RelSecaoModCjEstilosItem> RelSecaoModCjEstilosItems { get; set; } = new List<RelSecaoModCjEstilosItem>();

    public virtual ICollection<RelSecaoModeloEstilo> RelSecaoModeloEstilos { get; set; } = new List<RelSecaoModeloEstilo>();

    public virtual ICollection<SecaoDocumento> SecaoDocumentos { get; set; } = new List<SecaoDocumento>();
}
