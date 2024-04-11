using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSbsProjeto
{
    public int IdProjeto { get; set; }

    public int? IdSubVencaoSocial { get; set; }

    public string? CdProjeto { get; set; }

    public string? NmProjeto { get; set; }

    public virtual TbSbsSubvencaoSocial? IdSubVencaoSocialNavigation { get; set; }
}
