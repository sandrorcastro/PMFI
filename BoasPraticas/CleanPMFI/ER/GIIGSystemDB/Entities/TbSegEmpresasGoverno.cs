using System;
using System.Collections.Generic;

namespace GIIGSystemDB.Entities;

public partial class TbSegEmpresasGoverno
{
    public short IdEmpresa { get; set; }

    public string? NrCnpj { get; set; }

    public string? NmEmpresa { get; set; }

    public string? DsTipo { get; set; }

    public virtual ICollection<TbSegUsuario> TbSegUsuarios { get; set; } = new List<TbSegUsuario>();

    public virtual ICollection<TbSegUsuariosEmpresasModulo> TbSegUsuariosEmpresasModulos { get; set; } = new List<TbSegUsuariosEmpresasModulo>();
}
