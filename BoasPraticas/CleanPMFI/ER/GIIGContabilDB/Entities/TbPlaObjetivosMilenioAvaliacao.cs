using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaObjetivosMilenioAvaliacao
{
    public int IdAvaliacao { get; set; }

    public short IdEscopo { get; set; }

    public short IdObjetivoMilenio { get; set; }

    public short IdUnidadeMedidaPadrao { get; set; }

    public short NrAno { get; set; }

    public decimal? NrMedidaAlcancada { get; set; }

    public virtual TbPlaObjetivosMilenio IdObjetivoMilenioNavigation { get; set; } = null!;
}
