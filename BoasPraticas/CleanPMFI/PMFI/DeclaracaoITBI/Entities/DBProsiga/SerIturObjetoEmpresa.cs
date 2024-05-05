using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SerIturObjetoEmpresa
{
    public long ObjId { get; set; }

    public long EmprCmc { get; set; }

    public string? Descricao { get; set; }

    public virtual TribEmpresa EmprCmcNavigation { get; set; } = null!;

    public virtual SerIturObjeto Obj { get; set; } = null!;
}
