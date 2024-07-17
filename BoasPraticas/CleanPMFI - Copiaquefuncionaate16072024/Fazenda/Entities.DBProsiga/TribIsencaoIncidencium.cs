using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribIsencaoIncidencium
{
    public int TparamId { get; set; }

    public int ParamId { get; set; }

    public int TipoTribId { get; set; }

    /// <summary>
    /// Codigo utilizado para a baixa na Isenção
    /// </summary>
    public int? TipoBxId { get; set; }

    public virtual TribTipoBaixa? TipoBx { get; set; }

    public virtual TribTipoTributo TipoTrib { get; set; } = null!;

    public virtual TribParamCalculo TribParamCalculo { get; set; } = null!;
}
