using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class RelSecaoModCjEstilosItem
{
    public int IdSecaoModelo { get; set; }

    public int IdConjuntoEstilosItem { get; set; }

    public string SinPadrao { get; set; } = null!;

    public virtual ConjuntoEstilosItem IdConjuntoEstilosItemNavigation { get; set; } = null!;

    public virtual SecaoModelo IdSecaoModeloNavigation { get; set; } = null!;
}
