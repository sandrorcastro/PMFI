using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class RelBlocoProtocolo
{
    public long IdProtocolo { get; set; }

    public int IdBloco { get; set; }

    public string? Anotacao { get; set; }

    public int Sequencia { get; set; }

    public string? IdxRelBlocoProtocolo { get; set; }

    public virtual Bloco IdBlocoNavigation { get; set; } = null!;

    public virtual Protocolo IdProtocoloNavigation { get; set; } = null!;
}
