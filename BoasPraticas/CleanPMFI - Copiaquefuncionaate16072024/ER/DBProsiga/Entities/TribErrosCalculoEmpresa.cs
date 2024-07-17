using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribErrosCalculoEmpresa
{
    public decimal? Erro { get; set; }

    public int? EmprCmc { get; set; }

    public string? DescricaoErro { get; set; }
}
