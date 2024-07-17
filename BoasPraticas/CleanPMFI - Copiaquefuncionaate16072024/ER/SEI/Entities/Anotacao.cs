using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Anotacao
{
    public int IdAnotacao { get; set; }

    public int IdUnidade { get; set; }

    public long IdProtocolo { get; set; }

    public int IdUsuario { get; set; }

    public string? Descricao { get; set; }

    public DateTime DthAnotacao { get; set; }

    public string SinPrioridade { get; set; } = null!;

    public string StaAnotacao { get; set; } = null!;

    public virtual Protocolo IdProtocoloNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
