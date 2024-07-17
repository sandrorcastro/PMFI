using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribErrosCalculoEmpresa
{
    public decimal? Erro { get; set; }

    public int? EmprCmc { get; set; }

    public string? DescricaoErro { get; set; }
}
