using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TabAtributosDinamico
{
    public int TabParId { get; set; }

    public string? TabParTabela { get; set; }

    public string? TabParTipo { get; set; }

    public string? TabParNome { get; set; }

    public virtual ICollection<TribEdifAtributosDinamico> TribEdifAtributosDinamicos { get; set; } = new List<TribEdifAtributosDinamico>();
}
