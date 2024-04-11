using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class FoneTipo
{
    public long TipoFoneId { get; set; }

    /// <summary>
    /// Celular;Residencial;Comercial
    /// </summary>
    public string TipoFoneDescricao { get; set; } = null!;
}
