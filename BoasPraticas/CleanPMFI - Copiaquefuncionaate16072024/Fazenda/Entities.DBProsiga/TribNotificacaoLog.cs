using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribNotificacaoLog
{
    public long IdLogNotificacao { get; set; }

    public string? DsSession { get; set; }

    public long? IdCadastro { get; set; }

    public long? IdDivida { get; set; }

    public string? TpCadastro { get; set; }

    public string? DsErro { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtInclusao { get; set; }
}
