using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspEmpenhosAssinaturaEletronica
{
    public int IdAssinatura { get; set; }

    public int? IdObjeto { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtAssinatura { get; set; }

    public string? DsNotaAssinatura { get; set; }

    public string? DsTipoDocumento { get; set; }
}
