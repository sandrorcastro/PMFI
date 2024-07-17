using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Categorium
{
    public int IdCategoria { get; set; }

    public string Nome { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public virtual ICollection<Contato> Contatos { get; set; } = new List<Contato>();
}
