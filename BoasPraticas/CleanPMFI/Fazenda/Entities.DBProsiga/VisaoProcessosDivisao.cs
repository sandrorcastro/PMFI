using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class VisaoProcessosDivisao
{
    public long Id { get; set; }

    public long? Processo { get; set; }

    public string? Descricao { get; set; }

    public int? IdDivisao { get; set; }

    public string SituaçãoRecebimento { get; set; } = null!;

    public string? SituacaoProcesso { get; set; }
}
