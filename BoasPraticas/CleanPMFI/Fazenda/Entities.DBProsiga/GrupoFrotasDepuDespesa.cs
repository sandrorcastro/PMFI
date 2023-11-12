using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class GrupoFrotasDepuDespesa
{
    public int GfddidDespesa { get; set; }

    public string GfddcnpjFilial { get; set; } = null!;

    public long GfddveiculoId { get; set; }

    public string GfddtipoDespesa { get; set; } = null!;

    public short GfddanoDespesa { get; set; }

    public int GfddnumDespesa { get; set; }

    public decimal? GfddvalorDespesa { get; set; }

    public DateTime? GfdddataDespesa { get; set; }
}
