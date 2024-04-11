using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCtcCentroCustosNaturezaDespesa
{
    public int IdCentroCusto { get; set; }

    public string CategoriaEconomica { get; set; } = null!;

    public string GrupoNaturezaDespesa { get; set; } = null!;

    public string ModalidadeAplicacao { get; set; } = null!;

    public string ElementoDespesa { get; set; } = null!;

    public string Desdobramento { get; set; } = null!;

    public string Detalhamento { get; set; } = null!;

    public string? DsLogin { get; set; }

    public DateTime? DtInclusao { get; set; }

    public virtual TbCtcCentroCusto IdCentroCustoNavigation { get; set; } = null!;
}
