using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TbTempValidadorCdaprevium
{
    public int TpCadastro { get; set; }

    public long ImoIddivida { get; set; }

    public long Livrodaid { get; set; }

    public long? Agrupar { get; set; }

    public string Tipo { get; set; } = null!;

    public long? EdifEdificacaoEnglobamento { get; set; }

    public decimal Valor { get; set; }

    public decimal? CorrecaoMonetaria { get; set; }

    public decimal? Juros { get; set; }

    public decimal? Multa { get; set; }

    public decimal? MultaDividaAtiva { get; set; }

    public string? Ordem { get; set; }
}
