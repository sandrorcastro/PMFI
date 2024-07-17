using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class RelProtocoloAtributo
{
    public long IdProtocolo { get; set; }

    public int IdAtributo { get; set; }

    public string? Valor { get; set; }

    public virtual Atributo IdAtributoNavigation { get; set; } = null!;

    public virtual Protocolo IdProtocoloNavigation { get; set; } = null!;
}
