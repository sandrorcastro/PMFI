using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSbsRendimento
{
    public int IdRendimento { get; set; }

    public short? IdEmpresa { get; set; }

    public int? IdSubVencaoSocial { get; set; }

    public byte? NrMes { get; set; }

    public short? NrAno { get; set; }

    public decimal? VlRendimento { get; set; }

    public string? DsObservacoes { get; set; }

    public virtual TbSbsSubvencaoSocial? IdSubVencaoSocialNavigation { get; set; }
}
