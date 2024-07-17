using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPpaUnidadesMedidum
{
    public short IdUnidadeMedida { get; set; }

    public string? DsUnidadeMedida { get; set; }

    public virtual ICollection<TbPpaIndicadore> TbPpaIndicadores { get; set; } = new List<TbPpaIndicadore>();

    public virtual ICollection<TbPpaProgramasAco> TbPpaProgramasAcos { get; set; } = new List<TbPpaProgramasAco>();

    public virtual ICollection<TbSbsSubvencaoSocial> TbSbsSubvencaoSocials { get; set; } = new List<TbSbsSubvencaoSocial>();
}
