using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribProcExecutado
{
    public long ProcId { get; set; }

    public long ConId { get; set; }

    public string? ProcExecPrincipal { get; set; }

    public DateTime? DataInclusao { get; set; }

    public DateTime? DataAlteracao { get; set; }

    public string? UsuarioInclusao { get; set; }

    public string? UsuarioAlteracao { get; set; }

    public virtual TribProcProcesso Proc { get; set; } = null!;

    public virtual ICollection<TribProcAdvExecutado> TribProcAdvExecutados { get; set; } = new List<TribProcAdvExecutado>();

    public virtual TribProcExecSentenca? TribProcExecSentenca { get; set; }
}
