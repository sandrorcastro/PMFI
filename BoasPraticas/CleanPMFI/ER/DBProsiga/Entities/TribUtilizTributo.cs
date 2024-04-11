using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribUtilizTributo
{
    public int TipoUtilizTribId { get; set; }

    public int? TipoTribId { get; set; }

    public int? TparamId { get; set; }

    public int? ParamId { get; set; }

    public decimal? TipoUtilizTribAreaDe { get; set; }

    public decimal? TipoUtilizTribAreaAte { get; set; }

    public decimal? TipoUtilizTribQtdeUfm { get; set; }

    public short? TipoUtilizAno { get; set; }

    public int? CategId { get; set; }

    public decimal? TipoUtilizAreaTerrenoDe { get; set; }

    public decimal? TipoUtilizAreaTerrenoAte { get; set; }

    public int? TipoIseId { get; set; }

    public virtual TribTipoTributo? TipoTrib { get; set; }

    public virtual TribParamCalculo? TribParamCalculo { get; set; }
}
