using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribProcCitacao
{
    public long ProcCitId { get; set; }

    public long? ProcId { get; set; }

    public string? ProcCitRecebida { get; set; }

    public string? ProcCitMotivo { get; set; }

    public string? ProcCitForma { get; set; }

    public DateTime? ProcCitDataCitacao { get; set; }

    public long? ConId { get; set; }

    public DateTime? DataInclusao { get; set; }

    public DateTime? DataAlteracao { get; set; }

    public string? UsuarioInclusao { get; set; }

    public string? UsuarioAlteracao { get; set; }

    public virtual TribProcProcesso? Proc { get; set; }
}
