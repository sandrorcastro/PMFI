using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TempTbPlaAcoesPm
{
    public int IdAcao { get; set; }

    public short? IdEscopo { get; set; }

    public string CdAcao { get; set; } = null!;

    public int? IdVersaoCriacao { get; set; }

    public int? IdMovimento { get; set; }

    public string? TpComando { get; set; }

    public string? NmAcao { get; set; }
}
