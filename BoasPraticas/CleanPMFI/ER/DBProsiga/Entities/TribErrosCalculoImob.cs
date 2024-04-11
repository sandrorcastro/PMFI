using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribErrosCalculoImob
{
    public decimal? Erro { get; set; }

    public long? EdificacaoId { get; set; }

    public string? DescricaoErro { get; set; }
}
