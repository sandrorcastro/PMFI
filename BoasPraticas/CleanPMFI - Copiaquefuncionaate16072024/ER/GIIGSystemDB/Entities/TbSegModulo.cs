using System;
using System.Collections.Generic;

namespace GIIGSystemDB.Entities;

public partial class TbSegModulo
{
    public short IdModulo { get; set; }

    public string? NmModulo { get; set; }

    public string? DsModulo { get; set; }

    public short? NrOrdem { get; set; }

    public bool? FlMostrarLogin { get; set; }

    public virtual ICollection<TbGerAplicativo> TbGerAplicativos { get; set; } = new List<TbGerAplicativo>();

    public virtual ICollection<TbSegFormulario> TbSegFormularios { get; set; } = new List<TbSegFormulario>();

    public virtual ICollection<TbSegPerfisdeAcesso> TbSegPerfisdeAcessos { get; set; } = new List<TbSegPerfisdeAcesso>();

    public virtual ICollection<TbSegUsuariosEmpresasModulo> TbSegUsuariosEmpresasModulos { get; set; } = new List<TbSegUsuariosEmpresasModulo>();
}
