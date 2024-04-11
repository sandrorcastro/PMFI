using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaProgramaIndicador
{
    public int IdPrograma { get; set; }

    public int IdIndicador { get; set; }

    public int? IdVersaoVinculo { get; set; }

    public DateTime? DtVinculo { get; set; }

    public int? IdVersaoCancelamento { get; set; }

    public DateTime? DtCancelamento { get; set; }

    public string? DsNotaExplicativa { get; set; }

    public virtual TbPlaIndicadore IdIndicadorNavigation { get; set; } = null!;

    public virtual TbPlaPrograma IdProgramaNavigation { get; set; } = null!;

    public virtual TbPlaVerso? IdVersaoCancelamentoNavigation { get; set; }

    public virtual TbPlaVerso? IdVersaoVinculoNavigation { get; set; }
}
