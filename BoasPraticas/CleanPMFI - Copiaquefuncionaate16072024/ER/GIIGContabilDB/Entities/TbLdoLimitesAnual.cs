using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLdoLimitesAnual
{
    public int IdLimite { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public string? CdOrgao { get; set; }

    public int? IdNatDespesa { get; set; }

    public int? IdFonte { get; set; }

    public decimal? VlLimite { get; set; }

    public virtual TbGerEmpresasGoverno? IdEmpresaNavigation { get; set; }

    public virtual TbOrcFonte? IdFonteNavigation { get; set; }
}
