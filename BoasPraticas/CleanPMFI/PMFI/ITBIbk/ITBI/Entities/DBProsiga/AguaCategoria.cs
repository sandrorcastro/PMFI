using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class AguaCategoria
{
    /// <summary>
    /// Código de identificação da categoria de cobrança da água.
    /// </summary>
    public int CategId { get; set; }

    /// <summary>
    /// Nome da categoria de cobrança da água.
    /// </summary>
    public string? CategNome { get; set; }

    public virtual ICollection<AguaCategoriaTributo> AguaCategoriaTributos { get; set; } = new List<AguaCategoriaTributo>();

    public virtual ICollection<AguaTarifasAgua> AguaTarifasAguas { get; set; } = new List<AguaTarifasAgua>();
}
