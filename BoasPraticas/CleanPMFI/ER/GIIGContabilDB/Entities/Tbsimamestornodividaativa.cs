using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class Tbsimamestornodividaativa
{
    public int Idestorno { get; set; }

    public int? Nrsequencia { get; set; }

    public int? Nranosequencia { get; set; }

    public int? NrsequenciaDa { get; set; }

    public int? NranosequenciaDa { get; set; }

    public int? Idlei { get; set; }

    public DateTime? Dtestorno { get; set; }

    public decimal? Vlestorno { get; set; }

    public string? Dsmotivo { get; set; }

    public decimal? Vlatualizacao { get; set; }
}
