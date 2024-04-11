using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class EditalEliminacaoConteudo
{
    public int IdEditalEliminacaoConteudo { get; set; }

    public int IdAvaliacaoDocumental { get; set; }

    public int IdEditalEliminacao { get; set; }

    public int IdUsuarioInclusao { get; set; }

    public DateTime DthInclusao { get; set; }

    public virtual ICollection<EditalEliminacaoErro> EditalEliminacaoErros { get; set; } = new List<EditalEliminacaoErro>();

    public virtual AvaliacaoDocumental IdAvaliacaoDocumentalNavigation { get; set; } = null!;

    public virtual EditalEliminacao IdEditalEliminacaoNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioInclusaoNavigation { get; set; } = null!;
}
