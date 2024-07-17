using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSbsTipoExecuco
{
    public short IdTipoExecucao { get; set; }

    public string? DsTipoExecucao { get; set; }

    public virtual ICollection<TbSbsSubvencaoSocial> TbSbsSubvencaoSocials { get; set; } = new List<TbSbsSubvencaoSocial>();
}
