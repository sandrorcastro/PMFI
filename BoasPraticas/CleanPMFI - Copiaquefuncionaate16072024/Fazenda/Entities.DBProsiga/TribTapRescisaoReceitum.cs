using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribTapRescisaoReceitum
{
    public int ResRecId { get; set; }

    public int ResId { get; set; }

    public string? Receita { get; set; }

    public decimal? Valor { get; set; }

    public string? Tipo { get; set; }

    public short? IdTipoOperacaoReceita { get; set; }
}
