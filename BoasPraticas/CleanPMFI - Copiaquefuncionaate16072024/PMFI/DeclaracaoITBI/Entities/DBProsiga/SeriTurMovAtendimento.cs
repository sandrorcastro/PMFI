using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SeriTurMovAtendimento
{
    public long MoAtId { get; set; }

    public long? EmprCmc { get; set; }

    public long? EmprId { get; set; }

    public long? AtrativoId { get; set; }

    public long? IdmovOrigem { get; set; }

    public virtual SerIturAtrativosTuristico? Atrativo { get; set; }

    public virtual SerIturEmpresasSemCmc? Empr { get; set; }

    public virtual TribEmpresa? EmprCmcNavigation { get; set; }

    public virtual SeriTurOrigemTuristaCidadao? IdmovOrigemNavigation { get; set; }
}
