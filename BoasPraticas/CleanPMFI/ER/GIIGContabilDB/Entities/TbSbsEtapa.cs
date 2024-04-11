using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSbsEtapa
{
    public int IdEtapa { get; set; }

    public int? IdSubVencaoSocial { get; set; }

    public string? DsEtapaAtividade { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public decimal? VlPrevisto { get; set; }

    public virtual TbSbsSubvencaoSocial? IdSubVencaoSocialNavigation { get; set; }
}
