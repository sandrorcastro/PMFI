using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaTiposProjetoAtividade
{
    public short IdTipoProjetoAtividade { get; set; }

    public string? DsTipoProjetoAtividade { get; set; }

    public string? CdInicio { get; set; }

    public string? CdTipoAcao { get; set; }
}
