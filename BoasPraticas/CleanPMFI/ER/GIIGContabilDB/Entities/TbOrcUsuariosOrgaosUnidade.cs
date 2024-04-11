using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcUsuariosOrgaosUnidade
{
    public int IdPermissao { get; set; }

    public string? DsLogin { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public bool? FlPadrao { get; set; }

    public bool? FlAcessoRms { get; set; }
}
