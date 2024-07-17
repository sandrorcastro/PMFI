using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class AvaliacaoDocumental
{
    public int IdAvaliacaoDocumental { get; set; }

    public long IdProcedimento { get; set; }

    public int IdAssuntoProxy { get; set; }

    public int IdAssunto { get; set; }

    public int IdUsuario { get; set; }

    public int IdUnidade { get; set; }

    public string StaAvaliacao { get; set; } = null!;

    public DateTime DtaAvaliacao { get; set; }

    public virtual ICollection<CpadAvaliacao> CpadAvaliacaos { get; set; } = new List<CpadAvaliacao>();

    public virtual ICollection<EditalEliminacaoConteudo> EditalEliminacaoConteudos { get; set; } = new List<EditalEliminacaoConteudo>();

    public virtual Assunto IdAssuntoNavigation { get; set; } = null!;

    public virtual AssuntoProxy IdAssuntoProxyNavigation { get; set; } = null!;

    public virtual Procedimento IdProcedimentoNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
