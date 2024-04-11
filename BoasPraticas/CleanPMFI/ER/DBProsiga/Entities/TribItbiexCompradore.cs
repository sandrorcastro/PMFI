using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribItbiexCompradore
{
    public long ItbiedifId { get; set; }

    public long ConId { get; set; }

    public string ImprimeNaGuia { get; set; } = null!;

    public virtual Contribuinte Con { get; set; } = null!;

    public virtual TribItbiexEdif Itbiedif { get; set; } = null!;
}
