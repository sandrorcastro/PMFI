using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Psitema
{
    public long TemaId { get; set; }

    public long? TemaCabecObjId { get; set; }

    public long? TemaRodapeobjId { get; set; }

    public string? TemaTitulo { get; set; }

    public virtual ICollection<Psiformulario> Psiformularios { get; set; } = new List<Psiformulario>();

    public virtual Psiobjeto? TemaCabecObj { get; set; }

    public virtual Psiobjeto? TemaRodapeobj { get; set; }
}
