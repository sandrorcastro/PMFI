using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Modulo
{
    public int ModId { get; set; }

    public string? ModNome { get; set; }

    public string? ModDescricao { get; set; }

    public virtual ICollection<Formulario> Frms { get; set; } = new List<Formulario>();

    public virtual ICollection<Usuario> Usus { get; set; } = new List<Usuario>();
}
