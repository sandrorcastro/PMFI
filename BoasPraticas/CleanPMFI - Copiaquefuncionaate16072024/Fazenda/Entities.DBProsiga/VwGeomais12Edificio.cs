using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class VwGeomais12Edificio
{
    public string CdDistrito { get; set; } = null!;

    public string CdSetor { get; set; } = null!;

    public string NrQuadra { get; set; } = null!;

    public string NrLote { get; set; } = null!;

    public string NrEdificacao { get; set; } = null!;

    public long CdEdificio { get; set; }

    public string? NmEdificio { get; set; }

    public int? NrPavimentos { get; set; }

    public string DsBloco { get; set; } = null!;

    public string? DtConstrucao { get; set; }

    public int MdAreaComum { get; set; }

    public int MdAreaPrivativa { get; set; }

    public int MdAreaGaragem { get; set; }

    public string TipoCondominio { get; set; } = null!;
}
