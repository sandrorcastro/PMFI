using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribProcProcurador
{
    public long ProcId { get; set; }

    public long IdcontribCategProf { get; set; }

    public DateTime? DataInclusao { get; set; }

    public DateTime? DataExclusao { get; set; }

    public DateTime? DataAlteracao { get; set; }

    public string? UsuarioInclusao { get; set; }

    public string? UsuarioAlteracao { get; set; }

    public virtual TribProcProcesso Proc { get; set; } = null!;
}
