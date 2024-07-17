using System;
using System.Collections.Generic;

namespace GIIGSystemDB.Entities;

public partial class TbSegPerfisdeAcesso
{
    public short IdPerfilAcesso { get; set; }

    public string? NmPerfilAcesso { get; set; }

    public short? IdModulo { get; set; }

    public bool? FlAdmin { get; set; }

    public virtual TbSegModulo? IdModuloNavigation { get; set; }

    public virtual ICollection<TbSegPerfisdeAcessoFormulario> TbSegPerfisdeAcessoFormularios { get; set; } = new List<TbSegPerfisdeAcessoFormulario>();

    public virtual ICollection<TbSegUsuariosEmpresasModulo> TbSegUsuariosEmpresasModulos { get; set; } = new List<TbSegUsuariosEmpresasModulo>();
}
