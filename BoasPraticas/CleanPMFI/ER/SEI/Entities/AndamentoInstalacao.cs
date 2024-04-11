using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class AndamentoInstalacao
{
    public int IdAndamentoInstalacao { get; set; }

    public string IdInstalacaoFederacao { get; set; } = null!;

    public int IdTarefaInstalacao { get; set; }

    public int IdUnidade { get; set; }

    public int IdUsuario { get; set; }

    public string StaEstado { get; set; } = null!;

    public DateTime DthEstado { get; set; }

    public virtual ICollection<AtributoInstalacao> AtributoInstalacaos { get; set; } = new List<AtributoInstalacao>();

    public virtual InstalacaoFederacao IdInstalacaoFederacaoNavigation { get; set; } = null!;

    public virtual TarefaInstalacao IdTarefaInstalacaoNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
