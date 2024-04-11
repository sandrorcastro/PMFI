using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class RelSecaoModeloEstilo
{
    public int IdSecaoModelo { get; set; }

    public int IdEstilo { get; set; }

    public string SinPadrao { get; set; } = null!;

    public virtual Estilo IdEstiloNavigation { get; set; } = null!;

    public virtual SecaoModelo IdSecaoModeloNavigation { get; set; } = null!;
}
