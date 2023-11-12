using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class ImobensLoteamento
{
    public int IdLoteamento { get; set; }

    public string? Descricao { get; set; }

    public int? Idregiao { get; set; }

    public int? IdLoteamentoTribuno { get; set; }
}
