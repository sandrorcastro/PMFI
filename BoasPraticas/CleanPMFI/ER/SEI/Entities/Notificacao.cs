using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Notificacao
{
    public int IdNotificacao { get; set; }

    public long IdProcedimento { get; set; }

    public int IdUnidade { get; set; }

    public int IdUsuario { get; set; }

    public DateTime DthGeracao { get; set; }

    public int? IdAtividadeConfirmacao { get; set; }

    public virtual Atividade? IdAtividadeConfirmacaoNavigation { get; set; }

    public virtual Procedimento IdProcedimentoNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<RelNotificacaoDocumento> RelNotificacaoDocumentos { get; set; } = new List<RelNotificacaoDocumento>();
}
