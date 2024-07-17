using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class AndamentoSituacao
{
    public int IdAndamentoSituacao { get; set; }

    public DateTime DthExecucao { get; set; }

    public long IdProcedimento { get; set; }

    public int IdUnidade { get; set; }

    public int IdUsuario { get; set; }

    public int? IdSituacao { get; set; }

    public string SinUltimo { get; set; } = null!;

    public virtual Procedimento IdProcedimentoNavigation { get; set; } = null!;

    public virtual Situacao? IdSituacaoNavigation { get; set; }

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
