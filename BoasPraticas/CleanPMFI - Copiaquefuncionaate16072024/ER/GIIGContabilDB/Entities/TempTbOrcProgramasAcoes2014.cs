using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TempTbOrcProgramasAcoes2014
{
    public int IdAcao { get; set; }

    public short Idempresa { get; set; }

    public short NrAno { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public string CdFuncao { get; set; } = null!;

    public string CdSubFuncao { get; set; } = null!;

    public string CdPrograma { get; set; } = null!;

    public string CdAcao { get; set; } = null!;

    public string? DsAcao { get; set; }

    public string? DsQdd { get; set; }

    public decimal? NrMetaLimite { get; set; }

    public decimal? NrMetaExpansao { get; set; }

    public short? IdUnidadeMedida { get; set; }

    public decimal? VlLimite { get; set; }

    public decimal? VlExpansao { get; set; }

    public string? DsJustifLimite { get; set; }

    public string? DsJustifExpansao { get; set; }

    public byte? NrPrioridade { get; set; }

    public DateTime? DtLimite { get; set; }

    public string? DsTipo { get; set; }

    public DateTime? DtCadastro { get; set; }

    public string? FlPlanejamento { get; set; }
}
