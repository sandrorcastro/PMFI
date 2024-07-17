using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Observacao
{
    public int IdObservacao { get; set; }

    public long IdProtocolo { get; set; }

    public int IdUnidade { get; set; }

    public string Descricao { get; set; } = null!;

    public string? IdxObservacao { get; set; }

    public virtual Protocolo IdProtocoloNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;
}
