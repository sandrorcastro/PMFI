using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaObjetivosMilenioMedidasEsperada
{
    public int IdMedida { get; set; }

    public int IdVersaoMedida { get; set; }

    public short IdObjetivoMilenio { get; set; }

    public short IdUnidadeMedidaPadrao { get; set; }

    public short NrAnoAplicacao { get; set; }

    public decimal? NrMedidaEsperada { get; set; }

    public short? IdObjetivoDesenvSustentavel { get; set; }

    public virtual TbPlaObjetivosMilenio IdObjetivoMilenioNavigation { get; set; } = null!;

    public virtual TbPlaUnidadesMedidasPadrao IdUnidadeMedidaPadraoNavigation { get; set; } = null!;
}
