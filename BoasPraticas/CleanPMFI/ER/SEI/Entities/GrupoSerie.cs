using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class GrupoSerie
{
    public int IdGrupoSerie { get; set; }

    public string Nome { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public virtual ICollection<Serie> Series { get; set; } = new List<Serie>();
}
