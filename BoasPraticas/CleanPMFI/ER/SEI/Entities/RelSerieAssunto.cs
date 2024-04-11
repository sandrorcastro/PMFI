using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class RelSerieAssunto
{
    public int IdSerie { get; set; }

    public int Sequencia { get; set; }

    public int IdAssuntoProxy { get; set; }

    public virtual AssuntoProxy IdAssuntoProxyNavigation { get; set; } = null!;

    public virtual Serie IdSerieNavigation { get; set; } = null!;
}
