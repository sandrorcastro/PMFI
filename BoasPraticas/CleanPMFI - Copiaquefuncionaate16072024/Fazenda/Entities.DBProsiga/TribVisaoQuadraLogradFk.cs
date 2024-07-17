using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribVisaoQuadraLogradFk
{
    public int QuadraId { get; set; }

    public string? QuadraCodLocal { get; set; }

    public int LogradId { get; set; }

    public string? LogradNome { get; set; }

    public long FatorKid { get; set; }

    public string? FatorKnome { get; set; }
}
