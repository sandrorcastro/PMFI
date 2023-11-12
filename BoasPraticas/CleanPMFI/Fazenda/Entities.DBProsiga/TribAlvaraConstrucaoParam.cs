using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribAlvaraConstrucaoParam
{
    public long Numero { get; set; }

    public int TparamId { get; set; }

    public int ParamId { get; set; }

    public virtual TribParamCalculo TribParamCalculo { get; set; } = null!;
}
