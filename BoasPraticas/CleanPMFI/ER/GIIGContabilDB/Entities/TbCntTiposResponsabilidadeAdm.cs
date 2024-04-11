using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCntTiposResponsabilidadeAdm
{
    public short IdTipoRespAdm { get; set; }

    public string? DsTipoRespAdm { get; set; }

    public string? DsSigla { get; set; }

    public virtual ICollection<TbCntResponsabilidadesAdministrativa> TbCntResponsabilidadesAdministrativas { get; set; } = new List<TbCntResponsabilidadesAdministrativa>();
}
