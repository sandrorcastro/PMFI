using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribItbivendedore
{
    public long ItbiedifId { get; set; }

    public long ConId { get; set; }

    public string ImprimeNaGuia { get; set; } = null!;

    public virtual Contribuinte Con { get; set; } = null!;

    public virtual TribItbiedif Itbiedif { get; set; } = null!;
}
