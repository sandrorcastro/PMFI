using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribSisObraTabelaMensagem
{
    public int Idmensagem { get; set; }

    public string? Codigo { get; set; }

    public string? Descricao { get; set; }

    public virtual ICollection<TribSisObraLoteAlvaraMovimento> TribSisObraLoteAlvaraMovimentos { get; set; } = new List<TribSisObraLoteAlvaraMovimento>();
}
