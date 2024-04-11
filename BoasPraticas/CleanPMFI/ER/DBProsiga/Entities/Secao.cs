using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Secao
{
    public int? Secao1 { get; set; }

    public int? Bairro { get; set; }

    public int? Pavimento { get; set; }

    public int? Logradouro { get; set; }

    public decimal? ValorMetroQuadrado { get; set; }

    public int? Distrito { get; set; }

    public string? Cep { get; set; }

    public string? LadoSecao { get; set; }

    public int? Setor { get; set; }
}
