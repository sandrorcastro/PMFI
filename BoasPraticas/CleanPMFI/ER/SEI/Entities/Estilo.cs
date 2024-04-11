using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Estilo
{
    public int IdEstilo { get; set; }

    public string Nome { get; set; } = null!;

    public string Formatacao { get; set; } = null!;

    public virtual ICollection<RelSecaoModeloEstilo> RelSecaoModeloEstilos { get; set; } = new List<RelSecaoModeloEstilo>();
}
