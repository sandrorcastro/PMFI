using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SeriturPublicaEmpresa
{
    public int IdPublica { get; set; }

    public long? EmprCmc { get; set; }

    public long? EmprId { get; set; }

    public virtual SerIturEmpresasSemCmc? Empr { get; set; }

    public virtual TribEmpresa? EmprCmcNavigation { get; set; }
}
