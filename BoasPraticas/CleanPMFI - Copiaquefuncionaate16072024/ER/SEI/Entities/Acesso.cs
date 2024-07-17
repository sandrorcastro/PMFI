using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Acesso
{
    public int IdAcesso { get; set; }

    public int? IdUsuario { get; set; }

    public int IdUnidade { get; set; }

    public long IdProtocolo { get; set; }

    public string StaTipo { get; set; } = null!;

    public int? IdControleInterno { get; set; }

    public virtual ControleInterno? IdControleInternoNavigation { get; set; }

    public virtual Protocolo IdProtocoloNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
