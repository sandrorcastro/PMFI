using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TempTbCapRecurso
{
    public int IdRecurso { get; set; }

    public string? DsRecurso { get; set; }

    public short? IdEmpresa { get; set; }

    public string? CdFonte { get; set; }

    public int? IdOrgaoRepassador { get; set; }

    public string? DsTipoRecurso { get; set; }

    public string? CdContaContabilConsignar { get; set; }

    public string? DsSigla { get; set; }

    public bool? FlInativo { get; set; }
}
