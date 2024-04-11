using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCntTiposMotivoRescisaoContrato
{
    public short IdTipoMotivoRescisao { get; set; }

    public string? DsTipoMotivoRescisao { get; set; }

    public virtual ICollection<TbCntAtosContratuai> TbCntAtosContratuais { get; set; } = new List<TbCntAtosContratuai>();
}
