using System;
using System.Collections.Generic;

namespace GIIGSystemDB.Entities;

public partial class TbSegGruposServico
{
    public short IdGrupoServico { get; set; }

    public string? NmGrupoServico { get; set; }

    public virtual ICollection<TbSegFormulario> TbSegFormularios { get; set; } = new List<TbSegFormulario>();
}
