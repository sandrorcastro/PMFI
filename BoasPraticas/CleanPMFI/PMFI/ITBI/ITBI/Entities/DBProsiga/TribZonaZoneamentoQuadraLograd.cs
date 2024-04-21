using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribZonaZoneamentoQuadraLograd
{
    public int QuadraId { get; set; }

    public int LogradId { get; set; }

    public short ZozoId { get; set; }

    public decimal? ZoqlCaixaLogradouro { get; set; }

    public decimal? ZoqlRecuo { get; set; }

    public virtual TribQuadraLograd TribQuadraLograd { get; set; } = null!;

    public virtual TribZonaZoneamento Zozo { get; set; } = null!;
}
