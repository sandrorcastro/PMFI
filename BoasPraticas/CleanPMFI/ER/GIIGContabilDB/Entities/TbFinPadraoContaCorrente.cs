using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinPadraoContaCorrente
{
    public int IdPadraoContaCorrente { get; set; }

    public string? CdPadraoContaCorrente { get; set; }

    public string? DsPadraoContaCorrente { get; set; }

    public string? DsComposicao { get; set; }
}
