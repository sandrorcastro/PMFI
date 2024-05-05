using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class FoneTipo
{
    public long TipoFoneId { get; set; }

    /// <summary>
    /// Celular;Residencial;Comercial
    /// </summary>
    public string TipoFoneDescricao { get; set; } = null!;
}
