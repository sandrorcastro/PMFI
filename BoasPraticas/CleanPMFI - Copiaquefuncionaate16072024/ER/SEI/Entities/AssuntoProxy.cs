using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class AssuntoProxy
{
    public int IdAssuntoProxy { get; set; }

    public int IdAssunto { get; set; }

    public virtual ICollection<AvaliacaoDocumental> AvaliacaoDocumentals { get; set; } = new List<AvaliacaoDocumental>();

    public virtual Assunto IdAssuntoNavigation { get; set; } = null!;

    public virtual ICollection<RelProtocoloAssunto> RelProtocoloAssuntos { get; set; } = new List<RelProtocoloAssunto>();

    public virtual ICollection<RelSerieAssunto> RelSerieAssuntos { get; set; } = new List<RelSerieAssunto>();

    public virtual ICollection<RelTipoProcedimentoAssunto> RelTipoProcedimentoAssuntos { get; set; } = new List<RelTipoProcedimentoAssunto>();
}
