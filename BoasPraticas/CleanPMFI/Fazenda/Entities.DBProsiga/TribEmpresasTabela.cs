using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribEmpresasTabela
{
    public int TabelaId { get; set; }

    public string? TabelaNome { get; set; }

    public string? TabelaTipo { get; set; }

    public string? TabelaDescricao { get; set; }

    public virtual ICollection<TribEmpresasTabelaValorCalc> TribEmpresasTabelaValorCalcs { get; set; } = new List<TribEmpresasTabelaValorCalc>();
}
