using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class FissTiposDespacho
{
    public long IdtipoDespacho { get; set; }

    public string? NomeDespacho { get; set; }

    public virtual ICollection<FissDespachosServidore> FissDespachosServidores { get; set; } = new List<FissDespachosServidore>();
}
