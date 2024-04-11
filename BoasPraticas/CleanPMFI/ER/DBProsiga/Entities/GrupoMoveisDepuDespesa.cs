using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class GrupoMoveisDepuDespesa
{
    public long GmddidDespesa { get; set; }

    public string GmddcnpjFilial { get; set; } = null!;

    public long GmddmovEquipId { get; set; }

    public string GmddtipoDespesa { get; set; } = null!;

    public short GmddanoDespesa { get; set; }

    public int GmddnumDespesa { get; set; }

    public decimal? GmddvalorDespesa { get; set; }

    public DateTime? GmdddataDespesa { get; set; }
}
