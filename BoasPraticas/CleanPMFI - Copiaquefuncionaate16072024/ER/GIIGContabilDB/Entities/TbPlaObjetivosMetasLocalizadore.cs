using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaObjetivosMetasLocalizadore
{
    public int IdObjetivoMetaLocalizador { get; set; }

    public int IdObjetivoMeta { get; set; }

    public short NrAno { get; set; }

    public int IdLocalizador { get; set; }

    public decimal? NrMetaFisica { get; set; }

    public decimal? VlMetaFinanceira { get; set; }

    public short IdUnidadeMedida { get; set; }

    public virtual TbPlaLocalizadore IdLocalizadorNavigation { get; set; } = null!;

    public virtual TbPlaObjetivosMeta IdObjetivoMetaNavigation { get; set; } = null!;

    public virtual TbPlaUnidadesMedidum IdUnidadeMedidaNavigation { get; set; } = null!;
}
