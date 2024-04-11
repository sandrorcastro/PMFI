using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribDividasVinculoAnuencia
{
    public int IdDividaAnuencia { get; set; }

    public string? TpCadastroOrigem { get; set; }

    public string? TpCadastroDestino { get; set; }

    public long? IdDividaOrigem { get; set; }

    public long? IdDividaDestino { get; set; }

    public long? IdDa { get; set; }
}
