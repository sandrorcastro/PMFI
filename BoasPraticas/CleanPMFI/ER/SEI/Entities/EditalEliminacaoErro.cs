using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class EditalEliminacaoErro
{
    public int IdEditalEliminacaoErro { get; set; }

    public int IdEditalEliminacaoConteudo { get; set; }

    public DateTime DthErro { get; set; }

    public string TextoErro { get; set; } = null!;

    public virtual EditalEliminacaoConteudo IdEditalEliminacaoConteudoNavigation { get; set; } = null!;
}
