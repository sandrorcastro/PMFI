using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSbsTipoEntidade
{
    public byte IdTpEntidade { get; set; }

    public string? DsTpEntidade { get; set; }

    public virtual ICollection<TbSbsSubvencaoSocial> TbSbsSubvencaoSocials { get; set; } = new List<TbSbsSubvencaoSocial>();
}
