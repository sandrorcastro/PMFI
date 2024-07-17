using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribFiscAutoInfracoesAnexo
{
    public int Anexid { get; set; }

    public int? AutoId { get; set; }

    public int? ObjetoId { get; set; }

    public string? AnexObs { get; set; }

    public virtual TribFiscAutoInfraco? Auto { get; set; }

    public virtual TribObjeto? Objeto { get; set; }
}
