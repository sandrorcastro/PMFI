using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class AguaCategoriaTributo
{
    public long CategTributoId { get; set; }

    public int CategId { get; set; }

    public int TipoTribId { get; set; }

    public string? CategTributoTaxaPrinc { get; set; }

    public string? CategTributoOrigemValor { get; set; }

    public virtual AguaCategoria Categ { get; set; } = null!;

    public virtual TribTipoTributo TipoTrib { get; set; } = null!;
}
