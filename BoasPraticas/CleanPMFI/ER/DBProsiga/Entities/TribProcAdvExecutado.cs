using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribProcAdvExecutado
{
    public long ProcAdvExecId { get; set; }

    public long IdcontribCategProf { get; set; }

    public long ProcId { get; set; }

    public long ConId { get; set; }

    public DateTime DataInclusao { get; set; }

    public DateTime? DataExclusao { get; set; }

    public string? UsuarioInclusao { get; set; }

    public string? UsuarioExclusao { get; set; }

    public virtual TribContribCategProf IdcontribCategProfNavigation { get; set; } = null!;

    public virtual TribProcExecutado TribProcExecutado { get; set; } = null!;
}
