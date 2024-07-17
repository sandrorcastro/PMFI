using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSbsComplementosSit
{
    public int CdTabelaSit { get; set; }

    public string CdCampoSit { get; set; } = null!;

    public string? DsTabelaSit { get; set; }

    public string? DsCampoSit { get; set; }

    public virtual ICollection<TbSbsSubvencaoSocialCompl> IdSubVencaoSocials { get; set; } = new List<TbSbsSubvencaoSocialCompl>();
}
