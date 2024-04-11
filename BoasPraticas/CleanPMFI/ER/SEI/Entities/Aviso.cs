using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Aviso
{
    public int IdAviso { get; set; }

    public string StaAviso { get; set; } = null!;

    public string SinLiberado { get; set; } = null!;

    public DateTime DthInicio { get; set; }

    public DateTime DthFim { get; set; }

    public string? Descricao { get; set; }

    public string? Link { get; set; }

    public string Imagem { get; set; } = null!;

    public virtual ICollection<Orgao> IdOrgaos { get; set; } = new List<Orgao>();
}
