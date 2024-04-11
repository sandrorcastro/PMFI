using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribItbi
{
    public long Itbiid { get; set; }

    public DateTime? ItbidataLanc { get; set; }

    public string? Itbiobservacao { get; set; }

    public string? ItbiusuarioInclusao { get; set; }

    public DateTime? ItbidataInclusao { get; set; }

    public int? Itbinumero { get; set; }

    public int? Itbiano { get; set; }

    public string ItbidsTipo { get; set; } = null!;

    public long? ConId { get; set; }

    public string? ItbidsAlerta { get; set; }

    public virtual Contribuinte? Con { get; set; }

    public virtual ICollection<TribItbiedif> TribItbiedifs { get; set; } = new List<TribItbiedif>();
}
