using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class LugarLocalizador
{
    public int IdLugarLocalizador { get; set; }

    public int IdUnidade { get; set; }

    public string Nome { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual ICollection<Localizador> Localizadors { get; set; } = new List<Localizador>();
}
