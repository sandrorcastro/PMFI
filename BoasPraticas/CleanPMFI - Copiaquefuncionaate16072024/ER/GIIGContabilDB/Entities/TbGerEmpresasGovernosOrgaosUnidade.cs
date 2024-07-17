using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerEmpresasGovernosOrgaosUnidade
{
    public short IdEmpresaGovernoOrgaoUnidade { get; set; }

    public short? IdEmpresaGoverno { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }
}
