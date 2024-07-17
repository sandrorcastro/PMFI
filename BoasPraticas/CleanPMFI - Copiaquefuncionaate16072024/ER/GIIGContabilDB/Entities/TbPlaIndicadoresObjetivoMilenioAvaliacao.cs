using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaIndicadoresObjetivoMilenioAvaliacao
{
    public int IdIndicador { get; set; }

    public short IdObjetivoMilenio { get; set; }

    public short NrAno { get; set; }

    public decimal? VlAvaliacao { get; set; }

    public virtual TbPlaIndicadore IdIndicadorNavigation { get; set; } = null!;

    public virtual TbPlaObjetivosMilenio IdObjetivoMilenioNavigation { get; set; } = null!;
}
