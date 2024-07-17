using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class RelProtocoloAssunto
{
    public long IdProtocolo { get; set; }

    public int IdUnidade { get; set; }

    public int Sequencia { get; set; }

    public int IdAssuntoProxy { get; set; }

    public long? IdProtocoloProcedimento { get; set; }

    public virtual AssuntoProxy IdAssuntoProxyNavigation { get; set; } = null!;

    public virtual Protocolo IdProtocoloNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;
}
