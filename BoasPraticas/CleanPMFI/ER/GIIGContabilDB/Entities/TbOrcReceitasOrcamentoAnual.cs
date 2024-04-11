using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcReceitasOrcamentoAnual
{
    public int IdReceitaOrcamentoAnual { get; set; }

    public int IdReceita { get; set; }

    public decimal? VlOrcado { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public string? DsTipo { get; set; }

    public short? IdTipoOperacaoReceita { get; set; }

    public virtual TbOrcReceita IdReceitaNavigation { get; set; } = null!;
}
