using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class ConjuntoEstilosItem
{
    public int IdConjuntoEstilosItem { get; set; }

    public int IdConjuntoEstilos { get; set; }

    public string Nome { get; set; } = null!;

    public string Formatacao { get; set; } = null!;

    public virtual ConjuntoEstilo IdConjuntoEstilosNavigation { get; set; } = null!;

    public virtual ICollection<RelSecaoModCjEstilosItem> RelSecaoModCjEstilosItems { get; set; } = new List<RelSecaoModCjEstilosItem>();
}
