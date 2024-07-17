using System;
using System.Collections.Generic;

namespace GIIGSystemDB.Entities;

public partial class TbSegUsuariosEmpresasModulo
{
    public short IdEmpresa { get; set; }

    public string DsLogin { get; set; } = null!;

    public short IdModulo { get; set; }

    public short IdPerfilAcesso { get; set; }

    public DateTime? DtVigenciaIni { get; set; }

    public DateTime? DtVigenciaFim { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLoginInclusao { get; set; }

    public virtual TbSegUsuario DsLoginNavigation { get; set; } = null!;

    public virtual TbSegEmpresasGoverno IdEmpresaNavigation { get; set; } = null!;

    public virtual TbSegModulo IdModuloNavigation { get; set; } = null!;

    public virtual TbSegPerfisdeAcesso IdPerfilAcessoNavigation { get; set; } = null!;
}
