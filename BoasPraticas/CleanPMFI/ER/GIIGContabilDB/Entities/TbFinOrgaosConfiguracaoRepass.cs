using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinOrgaosConfiguracaoRepass
{
    public int IdRepasse { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public int? IdPessoa { get; set; }

    public string? CdContaContabil { get; set; }

    public string? CdFonte { get; set; }

    public string? CdContaContabilFavorecido { get; set; }
}
