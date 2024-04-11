using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class ImobensLoteamento
{
    public int IdLoteamento { get; set; }

    public string? Descricao { get; set; }

    public int? Idregiao { get; set; }

    public int? IdLoteamentoTribuno { get; set; }
}
